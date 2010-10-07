namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ETC1 : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ETC1()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.ETC1), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.ETC1(@__env);
			}
		}
		protected ETC1(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isValid5263;
		public static bool isValid(java.nio.Buffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._isValid5263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth5264;
		public static int getWidth(java.nio.Buffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getWidth5264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight5265;
		public static int getHeight(java.nio.Buffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getHeight5265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encodeBlock5266;
		public static void encodeBlock(java.nio.Buffer arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._encodeBlock5266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeBlock5267;
		public static void decodeBlock(java.nio.Buffer arg0, java.nio.Buffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._decodeBlock5267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEncodedDataSize5268;
		public static int getEncodedDataSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._getEncodedDataSize5268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encodeImage5269;
		public static void encodeImage(java.nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4, java.nio.Buffer arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._encodeImage5269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeImage5270;
		public static void decodeImage(java.nio.Buffer arg0, java.nio.Buffer arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._decodeImage5270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatHeader5271;
		public static void formatHeader(java.nio.Buffer arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._formatHeader5271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ETC15272;
		public ETC1()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.ETC1.staticClass, global::android.opengl.ETC1._ETC15272, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.ETC1.staticClass = @__class;
			global::android.opengl.ETC1._isValid5263 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "isValid", "(Ljava/nio/Buffer;)Z");
			global::android.opengl.ETC1._getWidth5264 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "getWidth", "(Ljava/nio/Buffer;)I");
			global::android.opengl.ETC1._getHeight5265 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "getHeight", "(Ljava/nio/Buffer;)I");
			global::android.opengl.ETC1._encodeBlock5266 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "encodeBlock", "(Ljava/nio/Buffer;ILjava/nio/Buffer;)V");
			global::android.opengl.ETC1._decodeBlock5267 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "decodeBlock", "(Ljava/nio/Buffer;Ljava/nio/Buffer;)V");
			global::android.opengl.ETC1._getEncodedDataSize5268 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "getEncodedDataSize", "(II)I");
			global::android.opengl.ETC1._encodeImage5269 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "encodeImage", "(Ljava/nio/Buffer;IIIILjava/nio/Buffer;)V");
			global::android.opengl.ETC1._decodeImage5270 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "decodeImage", "(Ljava/nio/Buffer;Ljava/nio/Buffer;IIII)V");
			global::android.opengl.ETC1._formatHeader5271 = @__env.GetStaticMethodID(global::android.opengl.ETC1.staticClass, "formatHeader", "(Ljava/nio/Buffer;II)V");
			global::android.opengl.ETC1._ETC15272 = @__env.GetMethodID(global::android.opengl.ETC1.staticClass, "<init>", "()V");
		}
	}
}
