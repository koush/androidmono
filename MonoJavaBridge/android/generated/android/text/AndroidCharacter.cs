namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidCharacter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AndroidCharacter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool mirror(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AndroidCharacter._m0.native == global::System.IntPtr.Zero)
				global::android.text.AndroidCharacter._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "mirror", "([CII)Z");
			return @__env.CallStaticBooleanMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void getDirectionalities(char[] arg0, byte[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AndroidCharacter._m1.native == global::System.IntPtr.Zero)
				global::android.text.AndroidCharacter._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getDirectionalities", "([C[BI)V");
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int getEastAsianWidth(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AndroidCharacter._m2.native == global::System.IntPtr.Zero)
				global::android.text.AndroidCharacter._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getEastAsianWidth", "(C)I");
			return @__env.CallStaticIntMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void getEastAsianWidths(char[] arg0, int arg1, int arg2, byte[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AndroidCharacter._m3.native == global::System.IntPtr.Zero)
				global::android.text.AndroidCharacter._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getEastAsianWidths", "([CII[B)V");
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static char getMirror(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AndroidCharacter._m4.native == global::System.IntPtr.Zero)
				global::android.text.AndroidCharacter._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getMirror", "(C)C");
			return @__env.CallStaticCharMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AndroidCharacter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AndroidCharacter._m5.native == global::System.IntPtr.Zero)
				global::android.text.AndroidCharacter._m5 = @__env.GetMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._m5);
			Init(@__env, handle);
		}
		public static int EAST_ASIAN_WIDTH_NEUTRAL
		{
			get
			{
				return 0;
			}
		}
		public static int EAST_ASIAN_WIDTH_AMBIGUOUS
		{
			get
			{
				return 1;
			}
		}
		public static int EAST_ASIAN_WIDTH_HALF_WIDTH
		{
			get
			{
				return 2;
			}
		}
		public static int EAST_ASIAN_WIDTH_FULL_WIDTH
		{
			get
			{
				return 3;
			}
		}
		public static int EAST_ASIAN_WIDTH_NARROW
		{
			get
			{
				return 4;
			}
		}
		public static int EAST_ASIAN_WIDTH_WIDE
		{
			get
			{
				return 5;
			}
		}
		static AndroidCharacter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AndroidCharacter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AndroidCharacter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
