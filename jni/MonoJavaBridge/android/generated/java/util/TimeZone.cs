namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimeZone_))]
	public abstract partial class TimeZone : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone26834;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._clone26834)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._clone26834)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getDefault26835;
		public static global::java.util.TimeZone getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getDefault26835)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26836;
		public virtual int getOffset(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone._getOffset26836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getOffset26836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26837;
		public abstract int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		internal static global::MonoJavaBridge.MethodId _setDefault26838;
		public static void setDefault(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._setDefault26838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26839;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1, java.util.Locale arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26840;
		public virtual global::java.lang.String getDisplayName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26840)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26840)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26841;
		public virtual global::java.lang.String getDisplayName(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26842;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getDisplayName26842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDisplayName26842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone26843;
		public static global::java.util.TimeZone getTimeZone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getTimeZone26843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset26844;
		public abstract int getRawOffset();
		internal static global::MonoJavaBridge.MethodId _getID26845;
		public virtual global::java.lang.String getID()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.TimeZone._getID26845)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getID26845)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasSameRules26846;
		public virtual bool hasSameRules(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone._hasSameRules26846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._hasSameRules26846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset26847;
		public abstract void setRawOffset(int arg0);
		internal static global::MonoJavaBridge.MethodId _setID26848;
		public virtual void setID(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimeZone._setID26848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._setID26848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDSTSavings26849;
		public virtual int getDSTSavings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone._getDSTSavings26849);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone.staticClass, global::java.util.TimeZone._getDSTSavings26849);
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime26850;
		public abstract bool useDaylightTime();
		internal static global::MonoJavaBridge.MethodId _inDaylightTime26851;
		public abstract bool inDaylightTime(java.util.Date arg0);
		internal static global::MonoJavaBridge.MethodId _getAvailableIDs26852;
		public static global::java.lang.String[] getAvailableIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs26852)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableIDs26853;
		public static global::java.lang.String[] getAvailableIDs(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._getAvailableIDs26853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _TimeZone26854;
		public TimeZone() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimeZone.staticClass, global::java.util.TimeZone._TimeZone26854);
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
		static TimeZone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
			global::java.util.TimeZone._clone26834 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.TimeZone._getDefault26835 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDefault", "()Ljava/util/TimeZone;");
			global::java.util.TimeZone._getOffset26836 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getOffset", "(J)I");
			global::java.util.TimeZone._getOffset26837 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone._setDefault26838 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setDefault", "(Ljava/util/TimeZone;)V");
			global::java.util.TimeZone._getDisplayName26839 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName26840 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName26841 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.TimeZone._getDisplayName26842 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDisplayName", "(ZI)Ljava/lang/String;");
			global::java.util.TimeZone._getTimeZone26843 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			global::java.util.TimeZone._getRawOffset26844 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone._getID26845 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getID", "()Ljava/lang/String;");
			global::java.util.TimeZone._hasSameRules26846 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z");
			global::java.util.TimeZone._setRawOffset26847 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone._setID26848 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setID", "(Ljava/lang/String;)V");
			global::java.util.TimeZone._getDSTSavings26849 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDSTSavings", "()I");
			global::java.util.TimeZone._useDaylightTime26850 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone._inDaylightTime26851 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
			global::java.util.TimeZone._getAvailableIDs26852 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "()[Ljava/lang/String;");
			global::java.util.TimeZone._getAvailableIDs26853 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "(I)[Ljava/lang/String;");
			global::java.util.TimeZone._TimeZone26854 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimeZone))]
	internal sealed partial class TimeZone_ : java.util.TimeZone
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TimeZone_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26857;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone_._getOffset26857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._getOffset26857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset26858;
		public override int getRawOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.TimeZone_._getRawOffset26858);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._getRawOffset26858);
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset26859;
		public override void setRawOffset(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimeZone_._setRawOffset26859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._setRawOffset26859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime26860;
		public override bool useDaylightTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone_._useDaylightTime26860);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._useDaylightTime26860);
		}
		internal static global::MonoJavaBridge.MethodId _inDaylightTime26861;
		public override bool inDaylightTime(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimeZone_._inDaylightTime26861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimeZone_.staticClass, global::java.util.TimeZone_._inDaylightTime26861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TimeZone_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
			global::java.util.TimeZone_._getOffset26857 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "getOffset", "(IIIIII)I");
			global::java.util.TimeZone_._getRawOffset26858 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "getRawOffset", "()I");
			global::java.util.TimeZone_._setRawOffset26859 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "setRawOffset", "(I)V");
			global::java.util.TimeZone_._useDaylightTime26860 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "useDaylightTime", "()Z");
			global::java.util.TimeZone_._inDaylightTime26861 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone_.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
