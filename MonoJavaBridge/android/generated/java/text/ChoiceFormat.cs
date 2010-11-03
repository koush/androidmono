namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChoiceFormat : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ChoiceFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.ChoiceFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.ChoiceFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ChoiceFormat.staticClass, "hashCode", "()I", ref global::java.text.ChoiceFormat._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.ChoiceFormat._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.ChoiceFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.ChoiceFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.ChoiceFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.ChoiceFormat._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static double nextDouble(double arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ChoiceFormat._m5.native == global::System.IntPtr.Zero)
				global::java.text.ChoiceFormat._m5 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(DZ)D");
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static double nextDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ChoiceFormat._m6.native == global::System.IntPtr.Zero)
				global::java.text.ChoiceFormat._m6 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(D)D");
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", ref global::java.text.ChoiceFormat._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Number;
		}
		public new global::java.lang.Object[] Formats
		{
			get
			{
				return getFormats();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.Object[] getFormats()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.text.ChoiceFormat.staticClass, "getFormats", "()[Ljava/lang/Object;", ref global::java.text.ChoiceFormat._m8) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ChoiceFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V", ref global::java.text.ChoiceFormat._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.ChoiceFormat.staticClass, "toPattern", "()Ljava/lang/String;", ref global::java.text.ChoiceFormat._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setChoices(double[] arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ChoiceFormat.staticClass, "setChoices", "([D[Ljava/lang/String;)V", ref global::java.text.ChoiceFormat._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new double[] Limits
		{
			get
			{
				return getLimits();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual double[] getLimits()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<double>(this, global::java.text.ChoiceFormat.staticClass, "getLimits", "()[D", ref global::java.text.ChoiceFormat._m12) as double[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static double previousDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ChoiceFormat._m13.native == global::System.IntPtr.Zero)
				global::java.text.ChoiceFormat._m13 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "previousDouble", "(D)D");
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public ChoiceFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ChoiceFormat._m14.native == global::System.IntPtr.Zero)
				global::java.text.ChoiceFormat._m14 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public ChoiceFormat(double[] arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.ChoiceFormat._m15.native == global::System.IntPtr.Zero)
				global::java.text.ChoiceFormat._m15 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "([D[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ChoiceFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ChoiceFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ChoiceFormat"));
		}
	}
}
