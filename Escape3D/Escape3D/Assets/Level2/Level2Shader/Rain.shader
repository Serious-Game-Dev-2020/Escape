// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'
// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Escape/Rain"
{
    Properties
    {
        _MainTex ("Main Texture", 2D) = "white" {}
        _Color ("Color Tint", Color) = (1,1,1,1)
        _VerticalBillboarding("Vertical Restraint", Range(0, 1)) = 1
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType"="Transparent" "DisableBatching" = "True" }

        Pass
        {
            Tags {"LightMode" = "ForwardBase"}
            
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fwdbase

            #include "Lighting.cginc"
            #include "AutoLight.cginc"
            #include "UnityCG.cginc"

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _Color;
            float _VerticalBillboarding;

            struct a2v
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            v2f vert (a2v v)
            {
                v2f o;
                //设置锚点，新空间的原点
                float3 center = float3 (0,0,0);
                //计算得到摄像机位置
                float3 viewer = mul(unity_WorldToObject, float4(_WorldSpaceCameraPos, 1));
                //将摄像机位置减去锚点得到的向量作为法向量，使物体看起来永远面向摄像机
                float3 normalDir = viewer - center;
                //用 _VerticalBillboarding 来控制广告牌类型. 1为面向camera； 0为永远向上。
                normalDir.y = normalDir.y * _VerticalBillboarding;
                normalDir = normalize(normalDir);
                //防止法向量与up向量平行导致计算错误。
                float3 upDir = abs(normalDir.y) > 0.999 ? float3(0,0,1) : float3(0,1,0);
                //计算得到右向量
                float3 rightDir = normalize(cross(upDir, normalDir));
                //计算得到上向量
                upDir = normalize(cross(normalDir, rightDir));
                //得到顶点相对于锚点的偏移量
                float3 centerOffs = v.vertex.xyz - center;
                //计算模型空间下，有特性的图形的顶点坐标
                float3 localPos = center + rightDir * centerOffs.x + upDir * centerOffs.y + normalDir * centerOffs.z;
                o.pos = UnityObjectToClipPos(float4(localPos, 1));
                o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, i.uv);
                c.rgb *= _Color.rgb;
                return c;
            }
            ENDCG
        }
    }
    FallBack "VertexLit"
}
