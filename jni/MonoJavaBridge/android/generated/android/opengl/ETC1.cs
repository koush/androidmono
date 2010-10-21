namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ETC1 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ETC1()
		{
			InitJNI();
		}
		protected ETC1(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isValid8078;
		public static bool isValid(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._isValid8078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth8079;
		public static int getWidth(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getWidth8079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeight8080;
		public static int getHeight(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getHeight8080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _encodeBlock8081;
		public static void encodeBlock(java.nio.Buffer arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._encodeBlock8081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _decodeBlock8082;
		public static void decodeBlock(java.nio.Buffer arg0, java.nio.Buffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._decodeBlock8082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedDataSize8083;
		public static int getEncodedDataSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getEncodedDataSize8083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _encodeImage8084;
		public static void encodeImage(java.nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4, java.nio.Buffer arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._encodeImage8084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _decodeImage8085;
		public static void decodeImage(java.nio.Buffer arg0, java.nio.Buffer arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._decodeImage8085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader8086;
		public static void formatHeader(java.nio.Buffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._formatHeader8086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _ETC18087;
		public ETC1()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._ETC18087);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.ETC1.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/ETC1"));
			global::android.opengl.ETC1._isValid8078 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "isValid", "(Ljava/nio/Buffer;)Z");
			global::android.opengl.ETC1._getWidth8079 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getWidth", "(Ljava/nio/Buffer;)I");
			global::android.opengl.ETC1._getHeight8080 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getHeight", "(Ljava/nio/Buffer;)I");
			global::android.opengl.ETC1._encodeBlock8081 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "encodeBlock", "(Ljava/nio/Buffer;ILjava/nio/Buffer;)V");
			global::android.opengl.ETC1._decodeBlock8082 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "decodeBlock", "(Ljava/nio/Buffer;Ljava/nio/Buffer;)V");
			global::android.opengl.ETC1._getEncodedDataSize8083 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getEncodedDataSize", "(II)I");
			global::android.opengl.ETC1._encodeImage8084 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "encodeImage", "(Ljava/nio/Buffer;IIIILjava/nio/Buffer;)V");
			global::android.opengl.ETC1._decodeImage8085 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "decodeImage", "(Ljava/nio/Buffer;Ljava/nio/Buffer;IIII)V");
			global::android.opengl.ETC1._formatHeader8086 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "formatHeader", "(Ljava/nio/Buffer;II)V");
			global::android.opengl.ETC1._ETC18087 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "<init>", "()V");
		}
	}
}
