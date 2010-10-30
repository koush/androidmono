namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Base64(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decode13700;
		public static byte[] decode(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._decode13700.native == global::System.IntPtr.Zero)
				global::android.util.Base64._decode13700 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "(Ljava/lang/String;I)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode13700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _decode13701;
		public static byte[] decode(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._decode13701.native == global::System.IntPtr.Zero)
				global::android.util.Base64._decode13701 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BI)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode13701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _decode13702;
		public static byte[] decode(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._decode13702.native == global::System.IntPtr.Zero)
				global::android.util.Base64._decode13702 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "decode", "([BIII)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._decode13702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encode13703;
		public static byte[] encode(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._encode13703.native == global::System.IntPtr.Zero)
				global::android.util.Base64._encode13703 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BIII)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encode13703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encode13704;
		public static byte[] encode(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._encode13704.native == global::System.IntPtr.Zero)
				global::android.util.Base64._encode13704 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encode", "([BI)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encode13704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _encodeToString13705;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._encodeToString13705.native == global::System.IntPtr.Zero)
				global::android.util.Base64._encodeToString13705 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encodeToString13705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encodeToString13706;
		public static global::java.lang.String encodeToString(byte[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64._encodeToString13706.native == global::System.IntPtr.Zero)
				global::android.util.Base64._encodeToString13706 = @__env.GetStaticMethodIDNoThrow(global::android.util.Base64.staticClass, "encodeToString", "([BIII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Base64.staticClass, global::android.util.Base64._encodeToString13706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
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
