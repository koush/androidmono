namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AndroidCharacter : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AndroidCharacter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.AndroidCharacter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.AndroidCharacter(@__env);
			}
		}
		protected AndroidCharacter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _mirror7311;
		public static bool mirror(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._mirror7311, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDirectionalities7312;
		public static void getDirectionalities(char[] arg0, byte[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getDirectionalities7312, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEastAsianWidth7313;
		public static int getEastAsianWidth(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getEastAsianWidth7313, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEastAsianWidths7314;
		public static void getEastAsianWidths(char[] arg0, int arg1, int arg2, byte[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getEastAsianWidths7314, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMirror7315;
		public static char getMirror(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getMirror7315, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AndroidCharacter7316;
		public AndroidCharacter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._AndroidCharacter7316, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.AndroidCharacter.staticClass = @__class;
			global::android.text.AndroidCharacter._mirror7311 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "mirror", "([CII)Z");
			global::android.text.AndroidCharacter._getDirectionalities7312 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getDirectionalities", "([C[BI)V");
			global::android.text.AndroidCharacter._getEastAsianWidth7313 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getEastAsianWidth", "(C)I");
			global::android.text.AndroidCharacter._getEastAsianWidths7314 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getEastAsianWidths", "([CII[B)V");
			global::android.text.AndroidCharacter._getMirror7315 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getMirror", "(C)C");
			global::android.text.AndroidCharacter._AndroidCharacter7316 = @__env.GetMethodID(global::android.text.AndroidCharacter.staticClass, "<init>", "()V");
		}
	}
}
