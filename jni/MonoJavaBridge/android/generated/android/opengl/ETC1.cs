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
		internal static global::MonoJavaBridge.MethodId _isValid5527;
		public static bool isValid(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._isValid5527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5528;
		public static int getWidth(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getWidth5528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5529;
		public static int getHeight(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getHeight5529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _encodeBlock5530;
		public static void encodeBlock(java.nio.Buffer arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._encodeBlock5530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _decodeBlock5531;
		public static void decodeBlock(java.nio.Buffer arg0, java.nio.Buffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._decodeBlock5531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getEncodedDataSize5532;
		public static int getEncodedDataSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getEncodedDataSize5532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _encodeImage5533;
		public static void encodeImage(java.nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4, java.nio.Buffer arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._encodeImage5533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _decodeImage5534;
		public static void decodeImage(java.nio.Buffer arg0, java.nio.Buffer arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._decodeImage5534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader5535;
		public static void formatHeader(java.nio.Buffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._formatHeader5535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _ETC15536;
		public ETC1()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._ETC15536);
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
			global::android.opengl.ETC1._isValid5527 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "isValid", "(Ljava/nio/Buffer;)Z");
			global::android.opengl.ETC1._getWidth5528 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getWidth", "(Ljava/nio/Buffer;)I");
			global::android.opengl.ETC1._getHeight5529 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getHeight", "(Ljava/nio/Buffer;)I");
			global::android.opengl.ETC1._encodeBlock5530 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "encodeBlock", "(Ljava/nio/Buffer;ILjava/nio/Buffer;)V");
			global::android.opengl.ETC1._decodeBlock5531 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "decodeBlock", "(Ljava/nio/Buffer;Ljava/nio/Buffer;)V");
			global::android.opengl.ETC1._getEncodedDataSize5532 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "getEncodedDataSize", "(II)I");
			global::android.opengl.ETC1._encodeImage5533 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "encodeImage", "(Ljava/nio/Buffer;IIIILjava/nio/Buffer;)V");
			global::android.opengl.ETC1._decodeImage5534 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "decodeImage", "(Ljava/nio/Buffer;Ljava/nio/Buffer;IIII)V");
			global::android.opengl.ETC1._formatHeader5535 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "formatHeader", "(Ljava/nio/Buffer;II)V");
			global::android.opengl.ETC1._ETC15536 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1.staticClass, "<init>", "()V");
		}
	}
}
