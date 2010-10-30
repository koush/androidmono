namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Base64(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static byte[] decode(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m0.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "(Ljava/lang/String;I)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static byte[] decode(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m1.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BI)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static byte[] decode(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m2.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BIII)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static byte[] encode(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m3.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m3 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BIII)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static byte[] encode(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m4.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m4 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BI)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m5.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m5 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._m6.native == global::System.IntPtr.Zero)
				global::android.util.Base64._m6 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BIII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
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
		static Base64()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64"));
		}
		internal static void InitJNI()
		{
		}
	}
}
