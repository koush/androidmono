namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class TimeZone : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static TimeZone() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.TimeZone), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected TimeZone(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12050; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone12050)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.TimeZone.staticClass, _clone12050)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault12051; 
		public static java.util.TimeZone getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, _getDefault12051)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffset12052; 
		public virtual int getOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return @__env.CallIntMethod(this, _getOffset12052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.TimeZone.staticClass, _getOffset12052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffset12053; 
		public abstract int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5); 
		internal static global::net.sf.jni4net.jni.MethodId _setDefault12054; 
		public static void setDefault(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.util.TimeZone.staticClass, _setDefault12054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12055; 
		public virtual java.lang.String getDisplayName(bool arg0, int arg1, java.util.Locale arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.TimeZone.staticClass, _getDisplayName12055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12056; 
		public virtual java.lang.String getDisplayName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12056)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.TimeZone.staticClass, _getDisplayName12056)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12057; 
		public virtual java.lang.String getDisplayName(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.TimeZone.staticClass, _getDisplayName12057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12058; 
		public virtual java.lang.String getDisplayName(bool arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.TimeZone.staticClass, _getDisplayName12058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone12059; 
		public static java.util.TimeZone getTimeZone(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, _getTimeZone12059, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRawOffset12060; 
		public abstract int getRawOffset(); 
		internal static global::net.sf.jni4net.jni.MethodId _getID12061; 
		public virtual java.lang.String getID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getID12061)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.TimeZone.staticClass, _getID12061)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSameRules12062; 
		public virtual bool hasSameRules(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return @__env.CallBooleanMethod(this, _hasSameRules12062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.TimeZone.staticClass, _hasSameRules12062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRawOffset12063; 
		public abstract void setRawOffset(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setID12064; 
		public virtual void setID(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				@__env.CallVoidMethod(this, _setID12064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.TimeZone.staticClass, _setID12064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDSTSavings12065; 
		public virtual int getDSTSavings() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.TimeZone)) 
				return @__env.CallIntMethod(this, _getDSTSavings12065); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.TimeZone.staticClass, _getDSTSavings12065); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _useDaylightTime12066; 
		public abstract bool useDaylightTime(); 
		internal static global::net.sf.jni4net.jni.MethodId _inDaylightTime12067; 
		public abstract bool inDaylightTime(java.util.Date arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableIDs12068; 
		public static java.lang.String[] getAvailableIDs() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, _getAvailableIDs12068)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableIDs12069; 
		public static java.lang.String[] getAvailableIDs(int arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.TimeZone.staticClass, _getAvailableIDs12069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TimeZone12070; 
		public TimeZone()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.TimeZone.staticClass, _TimeZone12070, this); 
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
			global::java.util.TimeZone._clone12050 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.TimeZone._getDefault12051 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getDefault", "()Ljava/util/TimeZone;"); 
			global::java.util.TimeZone._getOffset12052 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getOffset", "(J)I"); 
			global::java.util.TimeZone._getOffset12053 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getOffset", "(IIIIII)I"); 
			global::java.util.TimeZone._setDefault12054 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "setDefault", "(Ljava/util/TimeZone;)V"); 
			global::java.util.TimeZone._getDisplayName12055 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.TimeZone._getDisplayName12056 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "()Ljava/lang/String;"); 
			global::java.util.TimeZone._getDisplayName12057 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.TimeZone._getDisplayName12058 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZI)Ljava/lang/String;"); 
			global::java.util.TimeZone._getTimeZone12059 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;"); 
			global::java.util.TimeZone._getRawOffset12060 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getRawOffset", "()I"); 
			global::java.util.TimeZone._getID12061 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getID", "()Ljava/lang/String;"); 
			global::java.util.TimeZone._hasSameRules12062 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z"); 
			global::java.util.TimeZone._setRawOffset12063 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "setRawOffset", "(I)V"); 
			global::java.util.TimeZone._setID12064 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "setID", "(Ljava/lang/String;)V"); 
			global::java.util.TimeZone._getDSTSavings12065 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "getDSTSavings", "()I"); 
			global::java.util.TimeZone._useDaylightTime12066 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "useDaylightTime", "()Z"); 
			global::java.util.TimeZone._inDaylightTime12067 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z"); 
			global::java.util.TimeZone._getAvailableIDs12068 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getAvailableIDs", "()[Ljava/lang/String;"); 
			global::java.util.TimeZone._getAvailableIDs12069 = @__env.GetStaticMethodID(global::java.util.TimeZone.staticClass, "getAvailableIDs", "(I)[Ljava/lang/String;"); 
			global::java.util.TimeZone._TimeZone12070 = @__env.GetMethodID(global::java.util.TimeZone.staticClass, "<init>", "()V"); 
		} 
	} 
} 
