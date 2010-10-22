namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Base64()
		{
			InitJNI();
		}
		protected Base64(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decode13636;
		public static byte[] decode(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode13636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _decode13637;
		public static byte[] decode(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode13637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _decode13638;
		public static byte[] decode(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode13638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encode13639;
		public static byte[] encode(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encode13639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encode13640;
		public static byte[] encode(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encode13640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encodeToString13641;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encodeToString13641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encodeToString13642;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encodeToString13642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64"));
			global::android.util.Base64._decode13636 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "(Ljava/lang/String;I)[B");
			global::android.util.Base64._decode13637 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BI)[B");
			global::android.util.Base64._decode13638 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BIII)[B");
			global::android.util.Base64._encode13639 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BIII)[B");
			global::android.util.Base64._encode13640 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BI)[B");
			global::android.util.Base64._encodeToString13641 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BI)Ljava/lang/String;");
			global::android.util.Base64._encodeToString13642 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BIII)Ljava/lang/String;");
		}
	}
}
