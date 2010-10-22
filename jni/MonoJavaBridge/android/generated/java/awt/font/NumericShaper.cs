namespace java.awt.font
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class NumericShaper : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NumericShaper()
		{
			InitJNI();
		}
		internal NumericShaper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals18566;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.awt.font.NumericShaper._equals18566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._equals18566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18567;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.awt.font.NumericShaper._toString18567)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._toString18567)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18568;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.awt.font.NumericShaper._hashCode18568);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._hashCode18568);
		}
		internal static global::MonoJavaBridge.MethodId _shape18569;
		public void shape(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.awt.font.NumericShaper._shape18569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._shape18569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _shape18570;
		public void shape(char[] arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.awt.font.NumericShaper._shape18570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._shape18570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getShaper18571;
		public static global::java.awt.font.NumericShaper getShaper(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.awt.font.NumericShaper>(@__env.CallStaticObjectMethod(java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getShaper18571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.awt.font.NumericShaper;
		}
		internal static global::MonoJavaBridge.MethodId _getContextualShaper18572;
		public static global::java.awt.font.NumericShaper getContextualShaper(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.awt.font.NumericShaper>(@__env.CallStaticObjectMethod(java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getContextualShaper18572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.awt.font.NumericShaper;
		}
		internal static global::MonoJavaBridge.MethodId _getContextualShaper18573;
		public static global::java.awt.font.NumericShaper getContextualShaper(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.awt.font.NumericShaper>(@__env.CallStaticObjectMethod(java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getContextualShaper18573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.awt.font.NumericShaper;
		}
		internal static global::MonoJavaBridge.MethodId _isContextual18574;
		public bool isContextual() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.awt.font.NumericShaper._isContextual18574);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._isContextual18574);
		}
		public new int Ranges
		{
			get
			{
				return getRanges();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRanges18575;
		public int getRanges() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.awt.font.NumericShaper._getRanges18575);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.awt.font.NumericShaper.staticClass, global::java.awt.font.NumericShaper._getRanges18575);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.awt.font.NumericShaper.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/awt/font/NumericShaper"));
			global::java.awt.font.NumericShaper._equals18566 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.awt.font.NumericShaper._toString18567 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "toString", "()Ljava/lang/String;");
			global::java.awt.font.NumericShaper._hashCode18568 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "hashCode", "()I");
			global::java.awt.font.NumericShaper._shape18569 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "shape", "([CII)V");
			global::java.awt.font.NumericShaper._shape18570 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "shape", "([CIII)V");
			global::java.awt.font.NumericShaper._getShaper18571 = @__env.GetStaticMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getShaper", "(I)Ljava/awt/font/NumericShaper;");
			global::java.awt.font.NumericShaper._getContextualShaper18572 = @__env.GetStaticMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getContextualShaper", "(I)Ljava/awt/font/NumericShaper;");
			global::java.awt.font.NumericShaper._getContextualShaper18573 = @__env.GetStaticMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getContextualShaper", "(II)Ljava/awt/font/NumericShaper;");
			global::java.awt.font.NumericShaper._isContextual18574 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "isContextual", "()Z");
			global::java.awt.font.NumericShaper._getRanges18575 = @__env.GetMethodIDNoThrow(global::java.awt.font.NumericShaper.staticClass, "getRanges", "()I");
		}
	}
}
