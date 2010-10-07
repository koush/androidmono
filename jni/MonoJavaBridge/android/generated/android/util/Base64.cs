namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Base64 : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Base64()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Base64), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.Base64(@__env);
			}
		}
		protected Base64(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _decode8161;
		public static byte[] decode(java.lang.String arg0, int arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._decode8161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decode8162;
		public static byte[] decode(byte[] arg0, int arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._decode8162, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decode8163;
		public static byte[] decode(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._decode8163, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode8164;
		public static byte[] encode(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._encode8164, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode8165;
		public static byte[] encode(byte[] arg0, int arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._encode8165, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encodeToString8166;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._encodeToString8166, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encodeToString8167;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Base64.staticClass, global::android.util.Base64._encodeToString8167, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		public static int DEFAULT
		{
			get
			{
				return 0;
			}
		}
		public static int NO_PADDING
		{
			get
			{
				return 1;
			}
		}
		public static int NO_WRAP
		{
			get
			{
				return 2;
			}
		}
		public static int CRLF
		{
			get
			{
				return 4;
			}
		}
		public static int URL_SAFE
		{
			get
			{
				return 8;
			}
		}
		public static int NO_CLOSE
		{
			get
			{
				return 16;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.Base64.staticClass = @__class;
			global::android.util.Base64._decode8161 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "decode", "(Ljava/lang/String;I)[B");
			global::android.util.Base64._decode8162 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "decode", "([BI)[B");
			global::android.util.Base64._decode8163 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "decode", "([BIII)[B");
			global::android.util.Base64._encode8164 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "encode", "([BIII)[B");
			global::android.util.Base64._encode8165 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "encode", "([BI)[B");
			global::android.util.Base64._encodeToString8166 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "encodeToString", "([BI)Ljava/lang/String;");
			global::android.util.Base64._encodeToString8167 = @__env.GetStaticMethodID(global::android.util.Base64.staticClass, "encodeToString", "([BIII)Ljava/lang/String;");
		}
	}
}
