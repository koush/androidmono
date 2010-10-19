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
		internal static global::MonoJavaBridge.MethodId _equals19402;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.ChoiceFormat._equals19402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._equals19402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19403;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.ChoiceFormat._hashCode19403);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._hashCode19403);
		}
		internal static global::MonoJavaBridge.MethodId _clone19404;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._clone19404)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._clone19404)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format19405;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._format19405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._format19405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19406;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._format19406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._format19406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble19407;
		public static double nextDouble(double arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._nextDouble19407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble19408;
		public static double nextDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._nextDouble19408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse19409;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._parse19409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._parse19409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		public new global::java.lang.Object[] Formats
		{
			get
			{
				return getFormats();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormats19410;
		public virtual global::java.lang.Object[] getFormats() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._getFormats19410)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._getFormats19410)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern19411;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat._applyPattern19411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._applyPattern19411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern19412;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._toPattern19412)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._toPattern19412)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setChoices19413;
		public virtual void setChoices(double[] arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat._setChoices19413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._setChoices19413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new double[] Limits
		{
			get
			{
				return getLimits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLimits19414;
		public virtual double[] getLimits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat._getLimits19414)) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._getLimits19414)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _previousDouble19415;
		public static double previousDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._previousDouble19415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ChoiceFormat19416;
		public ChoiceFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._ChoiceFormat19416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ChoiceFormat19417;
		public ChoiceFormat(double[] arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ChoiceFormat.staticClass, global::java.text.ChoiceFormat._ChoiceFormat19417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ChoiceFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ChoiceFormat"));
			global::java.text.ChoiceFormat._equals19402 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ChoiceFormat._hashCode19403 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "hashCode", "()I");
			global::java.text.ChoiceFormat._clone19404 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.ChoiceFormat._format19405 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.ChoiceFormat._format19406 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.ChoiceFormat._nextDouble19407 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(DZ)D");
			global::java.text.ChoiceFormat._nextDouble19408 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "nextDouble", "(D)D");
			global::java.text.ChoiceFormat._parse19409 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.ChoiceFormat._getFormats19410 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "getFormats", "()[Ljava/lang/Object;");
			global::java.text.ChoiceFormat._applyPattern19411 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._toPattern19412 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.ChoiceFormat._setChoices19413 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "setChoices", "([D[Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._getLimits19414 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "getLimits", "()[D");
			global::java.text.ChoiceFormat._previousDouble19415 = @__env.GetStaticMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "previousDouble", "(D)D");
			global::java.text.ChoiceFormat._ChoiceFormat19416 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.ChoiceFormat._ChoiceFormat19417 = @__env.GetMethodIDNoThrow(global::java.text.ChoiceFormat.staticClass, "<init>", "([D[Ljava/lang/String;)V");
		}
	}
}
