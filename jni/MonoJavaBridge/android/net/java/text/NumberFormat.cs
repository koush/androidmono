namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class NumberFormat : java.text.Format
	{ 
		internal new static global::java.lang.Class staticClass; 
		static NumberFormat() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.text.NumberFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected NumberFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11706; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, _hashCode11706); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.NumberFormat.staticClass, _hashCode11706); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11707; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallBooleanMethod(this, _equals11707, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.NumberFormat.staticClass, _equals11707, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11708; 
		public abstract java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _format11709; 
		public virtual java.lang.String format(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _format11709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _format11709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11710; 
		public override java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, _format11710, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _format11710, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11711; 
		public abstract java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _format11712; 
		public virtual java.lang.String format(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _format11712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _format11712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11713; 
		public static java.text.NumberFormat getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getInstance11713)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11714; 
		public static java.text.NumberFormat getInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getInstance11714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse11715; 
		public virtual java.lang.Number parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Number>(@__env, @__env.CallObjectMethodPtr(this, _parse11715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Number>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _parse11715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse11716; 
		public abstract java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales11717; 
		public static java.util.Locale[] getAvailableLocales() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getAvailableLocales11717)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseObject11718; 
		public sealed override java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _parseObject11718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _parseObject11718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRoundingMode11719; 
		public virtual java.math.RoundingMode getRoundingMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallObjectMethodPtr(this, _getRoundingMode11719)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _getRoundingMode11719)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isParseIntegerOnly11720; 
		public virtual bool isParseIntegerOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallBooleanMethod(this, _isParseIntegerOnly11720); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.NumberFormat.staticClass, _isParseIntegerOnly11720); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParseIntegerOnly11721; 
		public virtual void setParseIntegerOnly(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setParseIntegerOnly11721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setParseIntegerOnly11721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberInstance11722; 
		public static java.text.NumberFormat getNumberInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getNumberInstance11722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberInstance11723; 
		public static java.text.NumberFormat getNumberInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getNumberInstance11723)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerInstance11724; 
		public static java.text.NumberFormat getIntegerInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getIntegerInstance11724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerInstance11725; 
		public static java.text.NumberFormat getIntegerInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getIntegerInstance11725)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyInstance11726; 
		public static java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getCurrencyInstance11726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyInstance11727; 
		public static java.text.NumberFormat getCurrencyInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getCurrencyInstance11727)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPercentInstance11728; 
		public static java.text.NumberFormat getPercentInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getPercentInstance11728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPercentInstance11729; 
		public static java.text.NumberFormat getPercentInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, _getPercentInstance11729)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGroupingUsed11730; 
		public virtual bool isGroupingUsed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallBooleanMethod(this, _isGroupingUsed11730); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.NumberFormat.staticClass, _isGroupingUsed11730); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupingUsed11731; 
		public virtual void setGroupingUsed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setGroupingUsed11731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setGroupingUsed11731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumIntegerDigits11732; 
		public virtual int getMaximumIntegerDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, _getMaximumIntegerDigits11732); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.NumberFormat.staticClass, _getMaximumIntegerDigits11732); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumIntegerDigits11733; 
		public virtual void setMaximumIntegerDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setMaximumIntegerDigits11733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setMaximumIntegerDigits11733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumIntegerDigits11734; 
		public virtual int getMinimumIntegerDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, _getMinimumIntegerDigits11734); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.NumberFormat.staticClass, _getMinimumIntegerDigits11734); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumIntegerDigits11735; 
		public virtual void setMinimumIntegerDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setMinimumIntegerDigits11735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setMinimumIntegerDigits11735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFractionDigits11736; 
		public virtual int getMaximumFractionDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, _getMaximumFractionDigits11736); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.NumberFormat.staticClass, _getMaximumFractionDigits11736); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumFractionDigits11737; 
		public virtual void setMaximumFractionDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setMaximumFractionDigits11737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setMaximumFractionDigits11737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFractionDigits11738; 
		public virtual int getMinimumFractionDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, _getMinimumFractionDigits11738); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.NumberFormat.staticClass, _getMinimumFractionDigits11738); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumFractionDigits11739; 
		public virtual void setMinimumFractionDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setMinimumFractionDigits11739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setMinimumFractionDigits11739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrency11740; 
		public virtual java.util.Currency getCurrency() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallObjectMethodPtr(this, _getCurrency11740)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.NumberFormat.staticClass, _getCurrency11740)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrency11741; 
		public virtual void setCurrency(java.util.Currency arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setCurrency11741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setCurrency11741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRoundingMode11742; 
		public virtual void setRoundingMode(java.math.RoundingMode arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, _setRoundingMode11742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.NumberFormat.staticClass, _setRoundingMode11742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NumberFormat11743; 
		protected NumberFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.NumberFormat.staticClass, _NumberFormat11743, this); 
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
			global::java.text.NumberFormat._hashCode11706 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "hashCode", "()I"); 
			global::java.text.NumberFormat._equals11707 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.text.NumberFormat._format11708 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.NumberFormat._format11709 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;"); 
			global::java.text.NumberFormat._format11710 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.NumberFormat._format11711 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.NumberFormat._format11712 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;"); 
			global::java.text.NumberFormat._getInstance11713 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getInstance11714 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._parse11715 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;"); 
			global::java.text.NumberFormat._parse11716 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;"); 
			global::java.text.NumberFormat._getAvailableLocales11717 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;"); 
			global::java.text.NumberFormat._parseObject11718 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;"); 
			global::java.text.NumberFormat._getRoundingMode11719 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;"); 
			global::java.text.NumberFormat._isParseIntegerOnly11720 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z"); 
			global::java.text.NumberFormat._setParseIntegerOnly11721 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V"); 
			global::java.text.NumberFormat._getNumberInstance11722 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getNumberInstance11723 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getIntegerInstance11724 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getIntegerInstance11725 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getCurrencyInstance11726 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getCurrencyInstance11727 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getPercentInstance11728 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getPercentInstance11729 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._isGroupingUsed11730 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z"); 
			global::java.text.NumberFormat._setGroupingUsed11731 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V"); 
			global::java.text.NumberFormat._getMaximumIntegerDigits11732 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I"); 
			global::java.text.NumberFormat._setMaximumIntegerDigits11733 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V"); 
			global::java.text.NumberFormat._getMinimumIntegerDigits11734 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I"); 
			global::java.text.NumberFormat._setMinimumIntegerDigits11735 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V"); 
			global::java.text.NumberFormat._getMaximumFractionDigits11736 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I"); 
			global::java.text.NumberFormat._setMaximumFractionDigits11737 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V"); 
			global::java.text.NumberFormat._getMinimumFractionDigits11738 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I"); 
			global::java.text.NumberFormat._setMinimumFractionDigits11739 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V"); 
			global::java.text.NumberFormat._getCurrency11740 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;"); 
			global::java.text.NumberFormat._setCurrency11741 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V"); 
			global::java.text.NumberFormat._setRoundingMode11742 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V"); 
			global::java.text.NumberFormat._NumberFormat11743 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "<init>", "()V"); 
		} 
	} 
} 
