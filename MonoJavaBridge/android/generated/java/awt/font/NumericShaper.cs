namespace java.awt.font
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class NumericShaper : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NumericShaper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals18684;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.awt.font.NumericShaper.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.awt.font.NumericShaper._equals18684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18685;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.awt.font.NumericShaper.staticClass, "toString", "()Ljava/lang/String;", ref global::java.awt.font.NumericShaper._toString18685) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18686;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.awt.font.NumericShaper.staticClass, "hashCode", "()I", ref global::java.awt.font.NumericShaper._hashCode18686);
		}
		internal static global::MonoJavaBridge.MethodId _shape18687;
		public void shape(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.awt.font.NumericShaper.staticClass, "shape", "([CII)V", ref global::java.awt.font.NumericShaper._shape18687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _shape18688;
		public void shape(char[] arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.awt.font.NumericShaper.staticClass, "shape", "([CIII)V", ref global::java.awt.font.NumericShaper._shape18688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getShaper18689;
		public static global::java.awt.font.NumericShaper getShaper(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.awt.font.NumericShaper._getShaper18689.native == global::System.IntPtr.Zero)
				global::java.awt.font.NumericShaper._getShaper18689 = @__env.GetStaticMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getShaper", "(I)Ljava/awt/font/NumericShaper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.awt.font.NumericShaper>(@__env.CallStaticObjectMethod(java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getShaper18689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.awt.font.NumericShaper;
		}
		internal static global::MonoJavaBridge.MethodId _getContextualShaper18690;
		public static global::java.awt.font.NumericShaper getContextualShaper(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.awt.font.NumericShaper._getContextualShaper18690.native == global::System.IntPtr.Zero)
				global::java.awt.font.NumericShaper._getContextualShaper18690 = @__env.GetStaticMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getContextualShaper", "(I)Ljava/awt/font/NumericShaper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.awt.font.NumericShaper>(@__env.CallStaticObjectMethod(java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getContextualShaper18690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.awt.font.NumericShaper;
		}
		internal static global::MonoJavaBridge.MethodId _getContextualShaper18691;
		public static global::java.awt.font.NumericShaper getContextualShaper(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.awt.font.NumericShaper._getContextualShaper18691.native == global::System.IntPtr.Zero)
				global::java.awt.font.NumericShaper._getContextualShaper18691 = @__env.GetStaticMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getContextualShaper", "(II)Ljava/awt/font/NumericShaper;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.awt.font.NumericShaper>(@__env.CallStaticObjectMethod(java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getContextualShaper18691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.awt.font.NumericShaper;
		}
		internal static global::MonoJavaBridge.MethodId _isContextual18692;
		public bool isContextual()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.awt.font.NumericShaper.staticClass, "isContextual", "()Z", ref global::java.awt.font.NumericShaper._isContextual18692);
		}
		public new int Ranges
		{
			get
			{
				return getRanges();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRanges18693;
		public int getRanges()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.awt.font.NumericShaper.staticClass, "getRanges", "()I", ref global::java.awt.font.NumericShaper._getRanges18693);
		}
		public static int EUROPEAN
		{
			get
			{
				return 1;
			}
		}
		public static int ARABIC
		{
			get
			{
				return 2;
			}
		}
		public static int EASTERN_ARABIC
		{
			get
			{
				return 4;
			}
		}
		public static int DEVANAGARI
		{
			get
			{
				return 8;
			}
		}
		public static int BENGALI
		{
			get
			{
				return 16;
			}
		}
		public static int GURMUKHI
		{
			get
			{
				return 32;
			}
		}
		public static int GUJARATI
		{
			get
			{
				return 64;
			}
		}
		public static int ORIYA
		{
			get
			{
				return 128;
			}
		}
		public static int TAMIL
		{
			get
			{
				return 256;
			}
		}
		public static int TELUGU
		{
			get
			{
				return 512;
			}
		}
		public static int KANNADA
		{
			get
			{
				return 1024;
			}
		}
		public static int MALAYALAM
		{
			get
			{
				return 2048;
			}
		}
		public static int THAI
		{
			get
			{
				return 4096;
			}
		}
		public static int LAO
		{
			get
			{
				return 8192;
			}
		}
		public static int TIBETAN
		{
			get
			{
				return 16384;
			}
		}
		public static int MYANMAR
		{
			get
			{
				return 32768;
			}
		}
		public static int ETHIOPIC
		{
			get
			{
				return 65536;
			}
		}
		public static int KHMER
		{
			get
			{
				return 131072;
			}
		}
		public static int MONGOLIAN
		{
			get
			{
				return 262144;
			}
		}
		public static int ALL_RANGES
		{
			get
			{
				return 524287;
			}
		}
		static NumericShaper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.awt.font.NumericShaper.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/awt/font/NumericShaper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
