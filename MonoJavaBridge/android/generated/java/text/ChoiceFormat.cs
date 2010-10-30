namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChoiceFormat : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ChoiceFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25264;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._equals25264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25265;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._hashCode25265);
		}
		internal static global::MonoJavaBridge.MethodId _clone25266;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._clone25266)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25267;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._format25267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25268;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._format25268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble25269;
		public static double nextDouble(double arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._nextDouble25269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble25270;
		public static double nextDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._nextDouble25270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse25271;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._parse25271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		public new global::java.lang.Object[] Formats
		{
			get
			{
				return getFormats();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormats25272;
		public virtual global::java.lang.Object[] getFormats()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._getFormats25272)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25273;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._applyPattern25273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25274;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._toPattern25274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setChoices25275;
		public virtual void setChoices(double[] arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._setChoices25275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new double[] Limits
		{
			get
			{
				return getLimits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLimits25276;
		public virtual double[] getLimits()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._getLimits25276)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _previousDouble25277;
		public static double previousDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._previousDouble25277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ChoiceFormat25278;
		public ChoiceFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._ChoiceFormat25278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ChoiceFormat25279;
		public ChoiceFormat(double[] arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._ChoiceFormat25279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ChoiceFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ChoiceFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ChoiceFormat"));
			global::java.text.ChoiceFormat._equals25264 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ChoiceFormat._hashCode25265 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "hashCode", "()I");
			global::java.text.ChoiceFormat._clone25266 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.ChoiceFormat._format25267 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.ChoiceFormat._format25268 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.ChoiceFormat._nextDouble25269 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(DZ)D");
			global::java.text.ChoiceFormat._nextDouble25270 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(D)D");
			global::java.text.ChoiceFormat._parse25271 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.ChoiceFormat._getFormats25272 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "getFormats", "()[Ljava/lang/Object;");
			global::java.text.ChoiceFormat._applyPattern25273 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._toPattern25274 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.ChoiceFormat._setChoices25275 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "setChoices", "([D[Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._getLimits25276 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "getLimits", "()[D");
			global::java.text.ChoiceFormat._previousDouble25277 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "previousDouble", "(D)D");
			global::java.text.ChoiceFormat._ChoiceFormat25278 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._ChoiceFormat25279 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "([D[Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
