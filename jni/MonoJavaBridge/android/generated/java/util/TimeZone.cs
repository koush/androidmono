namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class TimeZone : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal static global::java.lang.Class staticClass;
		static TimeZone()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.TimeZone), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected TimeZone(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13827;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.TimeZone._clone13827));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._clone13827));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefault13828;
		public static global::java.util.TimeZone getDefault() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, global::java.util.TimeZone._getDefault13828));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffset13829;
		public virtual int getOffset(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.TimeZone._getOffset13829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getOffset13829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffset13830;
		public abstract int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		internal static global::net.sf.jni4net.jni.MethodId _setDefault13831;
		public static void setDefault(java.util.TimeZone arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._setDefault13831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13832;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1, java.util.Locale arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.TimeZone._getDisplayName13832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName13832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13833;
		public virtual global::java.lang.String getDisplayName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.TimeZone._getDisplayName13833));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName13833));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13834;
		public virtual global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.TimeZone._getDisplayName13834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName13834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13835;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.TimeZone._getDisplayName13835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName13835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone13836;
		public static global::java.util.TimeZone getTimeZone(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, global::java.util.TimeZone._getTimeZone13836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRawOffset13837;
		public abstract int getRawOffset();
		internal static global::net.sf.jni4net.jni.MethodId _getID13838;
		public virtual global::java.lang.String getID() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.TimeZone._getID13838));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getID13838));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasSameRules13839;
		public virtual bool hasSameRules(java.util.TimeZone arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.TimeZone._hasSameRules13839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._hasSameRules13839, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRawOffset13840;
		public abstract void setRawOffset(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setID13841;
		public virtual void setID(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.TimeZone._setID13841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._setID13841, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDSTSavings13842;
		public virtual int getDSTSavings() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.TimeZone._getDSTSavings13842);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDSTSavings13842);
		}
		internal static global::net.sf.jni4net.jni.MethodId _useDaylightTime13843;
		public abstract bool useDaylightTime();
		internal static global::net.sf.jni4net.jni.MethodId _inDaylightTime13844;
		public abstract bool inDaylightTime(java.util.Date arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableIDs13845;
		public static global::java.lang.String[] getAvailableIDs() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs13845));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableIDs13846;
		public static global::java.lang.String[] getAvailableIDs(int arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs13846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TimeZone13847;
		public TimeZone()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.TimeZone.staticClass, global::java.util.TimeZone._TimeZone13847, this);
		}
		public static int SHORT
		{
			get
			{
				return 0;
			}
		}
		public static int LONG
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.TimeZone.staticClass = @__class;
			global::java.util.TimeZone._clone13827 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TimeZone._getDefault13828 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getDefault", "()Ljava/util/TimeZone;");
			global::java.util.TimeZone._getOffset13829 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getOffset", "(J)I");
			global::java.util.TimeZone._getOffset13830 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone._setDefault13831 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "setDefault", "(Ljava/util/TimeZone;)V");
			global::java.util.TimeZone._getDisplayName13832 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName13833 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName13834 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName13835 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZI)Ljava/lang/String;");
			global::java.util.TimeZone._getTimeZone13836 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			global::java.util.TimeZone._getRawOffset13837 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone._getID13838 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getID", "()Ljava/lang/String;");
			global::java.util.TimeZone._hasSameRules13839 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z");
			global::java.util.TimeZone._setRawOffset13840 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone._setID13841 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "setID", "(Ljava/lang/String;)V");
			global::java.util.TimeZone._getDSTSavings13842 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDSTSavings", "()I");
			global::java.util.TimeZone._useDaylightTime13843 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone._inDaylightTime13844 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
			global::java.util.TimeZone._getAvailableIDs13845 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getAvailableIDs", "()[Ljava/lang/String;");
			global::java.util.TimeZone._getAvailableIDs13846 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getAvailableIDs", "(I)[Ljava/lang/String;");
			global::java.util.TimeZone._TimeZone13847 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "<init>", "()V");
		}
	}
}
