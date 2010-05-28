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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12614; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._hashCode12614); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._hashCode12614); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12615; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallBooleanMethod(this, global::java.text.NumberFormat._equals12615, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._equals12615, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format12616; 
		public abstract global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _format12617; 
		public virtual global::java.lang.String format(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._format12617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format12617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format12618; 
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._format12618, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format12618, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format12619; 
		public abstract global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _format12620; 
		public virtual global::java.lang.String format(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._format12620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format12620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12621; 
		public static global::java.text.NumberFormat getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance12621)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12622; 
		public static global::java.text.NumberFormat getInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance12622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse12623; 
		public virtual global::java.lang.Number parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Number>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._parse12623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Number>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parse12623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse12624; 
		public abstract global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales12625; 
		public static global::java.util.Locale[] getAvailableLocales() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getAvailableLocales12625)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseObject12626; 
		public sealed override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._parseObject12626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parseObject12626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRoundingMode12627; 
		public virtual global::java.math.RoundingMode getRoundingMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._getRoundingMode12627)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getRoundingMode12627)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isParseIntegerOnly12628; 
		public virtual bool isParseIntegerOnly() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallBooleanMethod(this, global::java.text.NumberFormat._isParseIntegerOnly12628); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isParseIntegerOnly12628); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParseIntegerOnly12629; 
		public virtual void setParseIntegerOnly(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setParseIntegerOnly12629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setParseIntegerOnly12629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberInstance12630; 
		public static global::java.text.NumberFormat getNumberInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance12630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberInstance12631; 
		public static global::java.text.NumberFormat getNumberInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance12631)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerInstance12632; 
		public static global::java.text.NumberFormat getIntegerInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance12632, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerInstance12633; 
		public static global::java.text.NumberFormat getIntegerInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance12633)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyInstance12634; 
		public static global::java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance12634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyInstance12635; 
		public static global::java.text.NumberFormat getCurrencyInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance12635)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPercentInstance12636; 
		public static global::java.text.NumberFormat getPercentInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance12636, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPercentInstance12637; 
		public static global::java.text.NumberFormat getPercentInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance12637)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGroupingUsed12638; 
		public virtual bool isGroupingUsed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallBooleanMethod(this, global::java.text.NumberFormat._isGroupingUsed12638); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isGroupingUsed12638); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGroupingUsed12639; 
		public virtual void setGroupingUsed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setGroupingUsed12639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setGroupingUsed12639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumIntegerDigits12640; 
		public virtual int getMaximumIntegerDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMaximumIntegerDigits12640); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumIntegerDigits12640); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumIntegerDigits12641; 
		public virtual void setMaximumIntegerDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMaximumIntegerDigits12641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumIntegerDigits12641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumIntegerDigits12642; 
		public virtual int getMinimumIntegerDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMinimumIntegerDigits12642); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumIntegerDigits12642); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumIntegerDigits12643; 
		public virtual void setMinimumIntegerDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMinimumIntegerDigits12643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumIntegerDigits12643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFractionDigits12644; 
		public virtual int getMaximumFractionDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMaximumFractionDigits12644); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumFractionDigits12644); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumFractionDigits12645; 
		public virtual void setMaximumFractionDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMaximumFractionDigits12645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumFractionDigits12645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFractionDigits12646; 
		public virtual int getMinimumFractionDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return @__env.CallIntMethod(this, global::java.text.NumberFormat._getMinimumFractionDigits12646); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumFractionDigits12646); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimumFractionDigits12647; 
		public virtual void setMinimumFractionDigits(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setMinimumFractionDigits12647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumFractionDigits12647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrency12648; 
		public virtual global::java.util.Currency getCurrency() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.NumberFormat._getCurrency12648)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrency12648)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCurrency12649; 
		public virtual void setCurrency(java.util.Currency arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setCurrency12649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setCurrency12649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRoundingMode12650; 
		public virtual void setRoundingMode(java.math.RoundingMode arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.NumberFormat)) 
				@__env.CallVoidMethod(this, global::java.text.NumberFormat._setRoundingMode12650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setRoundingMode12650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NumberFormat12651; 
		protected NumberFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._NumberFormat12651, this); 
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
			global::java.text.NumberFormat._hashCode12614 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "hashCode", "()I"); 
			global::java.text.NumberFormat._equals12615 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.text.NumberFormat._format12616 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.NumberFormat._format12617 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;"); 
			global::java.text.NumberFormat._format12618 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.NumberFormat._format12619 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.NumberFormat._format12620 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;"); 
			global::java.text.NumberFormat._getInstance12621 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getInstance12622 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._parse12623 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;"); 
			global::java.text.NumberFormat._parse12624 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;"); 
			global::java.text.NumberFormat._getAvailableLocales12625 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;"); 
			global::java.text.NumberFormat._parseObject12626 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;"); 
			global::java.text.NumberFormat._getRoundingMode12627 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;"); 
			global::java.text.NumberFormat._isParseIntegerOnly12628 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z"); 
			global::java.text.NumberFormat._setParseIntegerOnly12629 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V"); 
			global::java.text.NumberFormat._getNumberInstance12630 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getNumberInstance12631 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getIntegerInstance12632 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getIntegerInstance12633 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getCurrencyInstance12634 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getCurrencyInstance12635 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getPercentInstance12636 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._getPercentInstance12637 = @__env.GetStaticMethodID(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;"); 
			global::java.text.NumberFormat._isGroupingUsed12638 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z"); 
			global::java.text.NumberFormat._setGroupingUsed12639 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V"); 
			global::java.text.NumberFormat._getMaximumIntegerDigits12640 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I"); 
			global::java.text.NumberFormat._setMaximumIntegerDigits12641 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V"); 
			global::java.text.NumberFormat._getMinimumIntegerDigits12642 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I"); 
			global::java.text.NumberFormat._setMinimumIntegerDigits12643 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V"); 
			global::java.text.NumberFormat._getMaximumFractionDigits12644 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I"); 
			global::java.text.NumberFormat._setMaximumFractionDigits12645 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V"); 
			global::java.text.NumberFormat._getMinimumFractionDigits12646 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I"); 
			global::java.text.NumberFormat._setMinimumFractionDigits12647 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V"); 
			global::java.text.NumberFormat._getCurrency12648 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;"); 
			global::java.text.NumberFormat._setCurrency12649 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V"); 
			global::java.text.NumberFormat._setRoundingMode12650 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V"); 
			global::java.text.NumberFormat._NumberFormat12651 = @__env.GetMethodID(global::java.text.NumberFormat.staticClass, "<init>", "()V"); 
		} 
	} 
} 
