namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ETC1 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ETC1(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isValid(java.nio.Buffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "isValid", "(Ljava/nio/Buffer;)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getWidth(java.nio.Buffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getWidth", "(Ljava/nio/Buffer;)I");
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int getHeight(java.nio.Buffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getHeight", "(Ljava/nio/Buffer;)I");
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void encodeBlock(java.nio.Buffer arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "encodeBlock", "(Ljava/nio/Buffer;ILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void decodeBlock(java.nio.Buffer arg0, java.nio.Buffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "decodeBlock", "(Ljava/nio/Buffer;Ljava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int getEncodedDataSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getEncodedDataSize", "(II)I");
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void encodeImage(java.nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4, java.nio.Buffer arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "encodeImage", "(Ljava/nio/Buffer;IIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void decodeImage(java.nio.Buffer arg0, java.nio.Buffer arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m7.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m7 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "decodeImage", "(Ljava/nio/Buffer;Ljava/nio/Buffer;IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void formatHeader(java.nio.Buffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m8.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m8 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "formatHeader", "(Ljava/nio/Buffer;II)V");
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ETC1() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.ETC1._m9.native == global::System.IntPtr.Zero)
				global::android.opengl.ETC1._m9 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._m9);
			Init(@__env, handle);
		}
		public static int ENCODED_BLOCK_SIZE
		{
			get
			{
				return 8;
			}
		}
		public static int DECODED_BLOCK_SIZE
		{
			get
			{
				return 48;
			}
		}
		public static int ETC_PKM_HEADER_SIZE
		{
			get
			{
				return 16;
			}
		}
		public static int ETC1_RGB8_OES
		{
			get
			{
				return 36196;
			}
		}
		static ETC1()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.ETC1.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/ETC1"));
		}
	}
}
