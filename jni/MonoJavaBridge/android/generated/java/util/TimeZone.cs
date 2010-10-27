namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimeZone_))]
	public abstract partial class TimeZone : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeZone()
		{
			InitJNI();
		}
		protected TimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone26833;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._clone26833)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._clone26833)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getDefault26834;
		public static global::java.util.TimeZone getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getDefault26834)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26835;
		public virtual int getOffset(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone._getOffset26835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getOffset26835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26836;
		public abstract int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		internal static global::MonoJavaBridge.MethodId _setDefault26837;
		public static void setDefault(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._setDefault26837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26838;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1, java.util.Locale arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26839;
		public virtual global::java.lang.String getDisplayName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26839)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26839)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26840;
		public virtual global::java.lang.String getDisplayName(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26841;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone26842;
		public static global::java.util.TimeZone getTimeZone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getTimeZone26842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset26843;
		public abstract int getRawOffset();
		internal static global::MonoJavaBridge.MethodId _getID26844;
		public virtual global::java.lang.String getID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getID26844)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getID26844)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasSameRules26845;
		public virtual bool hasSameRules(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone._hasSameRules26845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._hasSameRules26845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset26846;
		public abstract void setRawOffset(int arg0);
		internal static global::MonoJavaBridge.MethodId _setID26847;
		public virtual void setID(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimeZone._setID26847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._setID26847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDSTSavings26848;
		public virtual int getDSTSavings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone._getDSTSavings26848);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDSTSavings26848);
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime26849;
		public abstract bool useDaylightTime();
		internal static global::MonoJavaBridge.MethodId _inDaylightTime26850;
		public abstract bool inDaylightTime(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getAvailableIDs26851;
		public static global::java.lang.String[] getAvailableIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs26851)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableIDs26852;
		public static global::java.lang.String[] getAvailableIDs(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs26852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _TimeZone26853;
		public TimeZone() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimeZone.staticClass, global::java.util.TimeZone._TimeZone26853);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
			global::java.util.TimeZone._clone26833 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TimeZone._getDefault26834 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDefault", "()Ljava/util/TimeZone;");
			global::java.util.TimeZone._getOffset26835 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getOffset", "(J)I");
			global::java.util.TimeZone._getOffset26836 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone._setDefault26837 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setDefault", "(Ljava/util/TimeZone;)V");
			global::java.util.TimeZone._getDisplayName26838 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName26839 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName26840 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName26841 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZI)Ljava/lang/String;");
			global::java.util.TimeZone._getTimeZone26842 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			global::java.util.TimeZone._getRawOffset26843 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone._getID26844 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getID", "()Ljava/lang/String;");
			global::java.util.TimeZone._hasSameRules26845 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z");
			global::java.util.TimeZone._setRawOffset26846 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone._setID26847 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setID", "(Ljava/lang/String;)V");
			global::java.util.TimeZone._getDSTSavings26848 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDSTSavings", "()I");
			global::java.util.TimeZone._useDaylightTime26849 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone._inDaylightTime26850 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
			global::java.util.TimeZone._getAvailableIDs26851 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "()[Ljava/lang/String;");
			global::java.util.TimeZone._getAvailableIDs26852 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "(I)[Ljava/lang/String;");
			global::java.util.TimeZone._TimeZone26853 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimeZone))]
	internal sealed partial class TimeZone_ : java.util.TimeZone
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeZone_()
		{
			InitJNI();
		}
		internal TimeZone_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26856;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone_._getOffset26856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._getOffset26856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset26857;
		public override int getRawOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone_._getRawOffset26857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._getRawOffset26857);
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset26858;
		public override void setRawOffset(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimeZone_._setRawOffset26858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._setRawOffset26858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime26859;
		public override bool useDaylightTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone_._useDaylightTime26859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._useDaylightTime26859);
		}
		internal static global::MonoJavaBridge.MethodId _inDaylightTime26860;
		public override bool inDaylightTime(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone_._inDaylightTime26860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._inDaylightTime26860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
			global::java.util.TimeZone_._getOffset26856 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone_._getRawOffset26857 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone_._setRawOffset26858 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone_._useDaylightTime26859 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone_._inDaylightTime26860 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
		}
	}
}
