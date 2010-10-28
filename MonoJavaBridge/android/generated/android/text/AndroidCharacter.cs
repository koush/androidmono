namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidCharacter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AndroidCharacter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _mirror12673;
		public static bool mirror(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._mirror12673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionalities12674;
		public static void getDirectionalities(char[] arg0, byte[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getDirectionalities12674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getEastAsianWidth12675;
		public static int getEastAsianWidth(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getEastAsianWidth12675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEastAsianWidths12676;
		public static void getEastAsianWidths(char[] arg0, int arg1, int arg2, byte[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getEastAsianWidths12676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getMirror12677;
		public static char getMirror(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getMirror12677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidCharacter12678;
		public AndroidCharacter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._AndroidCharacter12678);
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
			global::android.text.AndroidCharacter._mirror12673 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "mirror", "([CII)Z");
			global::android.text.AndroidCharacter._getDirectionalities12674 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getDirectionalities", "([C[BI)V");
			global::android.text.AndroidCharacter._getEastAsianWidth12675 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getEastAsianWidth", "(C)I");
			global::android.text.AndroidCharacter._getEastAsianWidths12676 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getEastAsianWidths", "([CII[B)V");
			global::android.text.AndroidCharacter._getMirror12677 = @__env.GetStaticMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "getMirror", "(C)C");
			global::android.text.AndroidCharacter._AndroidCharacter12678 = @__env.GetMethodIDNoThrow(global::android.text.AndroidCharacter.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
