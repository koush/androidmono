namespace java.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class NumberFormat : java.text.Format
	{
		internal new static global::java.lang.Class staticClass;
		static NumberFormat()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.NumberFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected NumberFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13442;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.NumberFormat._equals13442, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._equals13442, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13443;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._hashCode13443);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._hashCode13443);
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13444;
		public virtual global::java.lang.String format(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._format13444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format13444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13445;
		public abstract global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::net.sf.jni4net.jni.MethodId _format13446;
		public abstract global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::net.sf.jni4net.jni.MethodId _format13447;
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._format13447, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format13447, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13448;
		public virtual global::java.lang.String format(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._format13448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format13448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13449;
		public static global::java.text.NumberFormat getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance13449));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13450;
		public static global::java.text.NumberFormat getInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance13450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13451;
		public virtual global::java.lang.Number parse(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Number>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._parse13451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Number>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parse13451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13452;
		public abstract global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales13453;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getAvailableLocales13453));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseObject13454;
		public sealed override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._parseObject13454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parseObject13454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRoundingMode13455;
		public virtual global::java.math.RoundingMode getRoundingMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._getRoundingMode13455));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getRoundingMode13455));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isParseIntegerOnly13456;
		public virtual bool isParseIntegerOnly() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.NumberFormat._isParseIntegerOnly13456);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isParseIntegerOnly13456);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParseIntegerOnly13457;
		public virtual void setParseIntegerOnly(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setParseIntegerOnly13457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setParseIntegerOnly13457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberInstance13458;
		public static global::java.text.NumberFormat getNumberInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance13458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberInstance13459;
		public static global::java.text.NumberFormat getNumberInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance13459));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerInstance13460;
		public static global::java.text.NumberFormat getIntegerInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance13460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerInstance13461;
		public static global::java.text.NumberFormat getIntegerInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance13461));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyInstance13462;
		public static global::java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance13462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyInstance13463;
		public static global::java.text.NumberFormat getCurrencyInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance13463));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPercentInstance13464;
		public static global::java.text.NumberFormat getPercentInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance13464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPercentInstance13465;
		public static global::java.text.NumberFormat getPercentInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance13465));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGroupingUsed13466;
		public virtual bool isGroupingUsed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.NumberFormat._isGroupingUsed13466);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isGroupingUsed13466);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGroupingUsed13467;
		public virtual void setGroupingUsed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setGroupingUsed13467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setGroupingUsed13467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumIntegerDigits13468;
		public virtual int getMaximumIntegerDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMaximumIntegerDigits13468);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumIntegerDigits13468);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumIntegerDigits13469;
		public virtual void setMaximumIntegerDigits(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMaximumIntegerDigits13469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumIntegerDigits13469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumIntegerDigits13470;
		public virtual int getMinimumIntegerDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMinimumIntegerDigits13470);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumIntegerDigits13470);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumIntegerDigits13471;
		public virtual void setMinimumIntegerDigits(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMinimumIntegerDigits13471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumIntegerDigits13471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFractionDigits13472;
		public virtual int getMaximumFractionDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMaximumFractionDigits13472);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumFractionDigits13472);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumFractionDigits13473;
		public virtual void setMaximumFractionDigits(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMaximumFractionDigits13473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumFractionDigits13473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFractionDigits13474;
		public virtual int getMinimumFractionDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMinimumFractionDigits13474);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumFractionDigits13474);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumFractionDigits13475;
		public virtual void setMinimumFractionDigits(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMinimumFractionDigits13475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumFractionDigits13475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrency13476;
		public virtual global::java.util.Currency getCurrency() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._getCurrency13476));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrency13476));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCurrency13477;
		public virtual void setCurrency(java.util.Currency arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setCurrency13477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setCurrency13477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRoundingMode13478;
		public virtual void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setRoundingMode13478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setRoundingMode13478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NumberFormat13479;
		protected NumberFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._NumberFormat13479, this);
		}
		public static int INTEGER_FIELD
		{
			get
			{
				return 0;
			}
		}
		public static int FRACTION_FIELD
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.text.NumberFormat.staticClass = @__class;
			global::java.text.NumberFormat._equals13442 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.NumberFormat._hashCode13443 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "hashCode", "()I");
			global::java.text.NumberFormat._format13444 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;");
			global::java.text.NumberFormat._format13445 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format13446 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format13447 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format13448 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;");
			global::java.text.NumberFormat._getInstance13449 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getInstance13450 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._parse13451 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;");
			global::java.text.NumberFormat._parse13452 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.NumberFormat._getAvailableLocales13453 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.NumberFormat._parseObject13454 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.NumberFormat._getRoundingMode13455 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.NumberFormat._isParseIntegerOnly13456 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z");
			global::java.text.NumberFormat._setParseIntegerOnly13457 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V");
			global::java.text.NumberFormat._getNumberInstance13458 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getNumberInstance13459 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance13460 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance13461 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance13462 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance13463 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance13464 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance13465 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._isGroupingUsed13466 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z");
			global::java.text.NumberFormat._setGroupingUsed13467 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V");
			global::java.text.NumberFormat._getMaximumIntegerDigits13468 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMaximumIntegerDigits13469 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumIntegerDigits13470 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMinimumIntegerDigits13471 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMaximumFractionDigits13472 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.NumberFormat._setMaximumFractionDigits13473 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumFractionDigits13474 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.NumberFormat._setMinimumFractionDigits13475 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getCurrency13476 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.NumberFormat._setCurrency13477 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.NumberFormat._setRoundingMode13478 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.NumberFormat._NumberFormat13479 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "<init>", "()V");
		}
	}
}
