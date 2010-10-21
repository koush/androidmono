namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ChoiceFormat : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ChoiceFormat()
		{
			InitJNI();
		}
		protected ChoiceFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25145;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.ChoiceFormat._equals25145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._equals25145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25146;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ChoiceFormat._hashCode25146);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._hashCode25146);
		}
		internal static global::MonoJavaBridge.MethodId _clone25147;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._clone25147)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._clone25147)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25148;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._format25148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._format25148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25149;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._format25149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._format25149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble25150;
		public static double nextDouble(double arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._nextDouble25150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble25151;
		public static double nextDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._nextDouble25151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse25152;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._parse25152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._parse25152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		public new global::java.lang.Object[] Formats
		{
			get
			{
				return getFormats();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormats25153;
		public virtual global::java.lang.Object[] getFormats() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._getFormats25153)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._getFormats25153)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25154;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat._applyPattern25154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._applyPattern25154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25155;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._toPattern25155)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._toPattern25155)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setChoices25156;
		public virtual void setChoices(double[] arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat._setChoices25156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._setChoices25156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new double[] Limits
		{
			get
			{
				return getLimits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLimits25157;
		public virtual double[] getLimits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._getLimits25157)) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._getLimits25157)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _previousDouble25158;
		public static double previousDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._previousDouble25158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ChoiceFormat25159;
		public ChoiceFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._ChoiceFormat25159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ChoiceFormat25160;
		public ChoiceFormat(double[] arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._ChoiceFormat25160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ChoiceFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ChoiceFormat"));
			global::java.text.ChoiceFormat._equals25145 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ChoiceFormat._hashCode25146 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "hashCode", "()I");
			global::java.text.ChoiceFormat._clone25147 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.ChoiceFormat._format25148 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.ChoiceFormat._format25149 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.ChoiceFormat._nextDouble25150 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(DZ)D");
			global::java.text.ChoiceFormat._nextDouble25151 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(D)D");
			global::java.text.ChoiceFormat._parse25152 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.ChoiceFormat._getFormats25153 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "getFormats", "()[Ljava/lang/Object;");
			global::java.text.ChoiceFormat._applyPattern25154 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._toPattern25155 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.ChoiceFormat._setChoices25156 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "setChoices", "([D[Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._getLimits25157 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "getLimits", "()[D");
			global::java.text.ChoiceFormat._previousDouble25158 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "previousDouble", "(D)D");
			global::java.text.ChoiceFormat._ChoiceFormat25159 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._ChoiceFormat25160 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "([D[Ljava/lang/String;)V");
		}
	}
}
