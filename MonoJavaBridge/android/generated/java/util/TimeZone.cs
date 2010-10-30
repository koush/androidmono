namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimeZone_))]
	public abstract partial class TimeZone : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.TimeZone.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.TimeZone._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.TimeZone getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimeZone._m1.native == global::System.IntPtr.Zero)
				global::java.util.TimeZone._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getDefault", "()Ljava/util/TimeZone;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._m1)) as java.util.TimeZone;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getOffset(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TimeZone.staticClass, "getOffset", "(J)I", ref global::java.util.TimeZone._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		private static global::MonoJavaBridge.MethodId _m4;
		public static void setDefault(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimeZone._m4.native == global::System.IntPtr.Zero)
				global::java.util.TimeZone._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "setDefault", "(Ljava/util/TimeZone;)V");
			@__env.CallStaticVoidMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1, java.util.Locale arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.TimeZone.staticClass, "getDisplayName", "(ZILjava/util/Locale;)Ljava/lang/String;", ref global::java.util.TimeZone._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getDisplayName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.TimeZone.staticClass, "getDisplayName", "()Ljava/lang/String;", ref global::java.util.TimeZone._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getDisplayName(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.TimeZone.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.TimeZone._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getDisplayName(bool arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.TimeZone.staticClass, "getDisplayName", "(ZI)Ljava/lang/String;", ref global::java.util.TimeZone._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.TimeZone getTimeZone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimeZone._m9.native == global::System.IntPtr.Zero)
				global::java.util.TimeZone._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getTimeZone", "(Ljava/lang/String;)Ljava/util/TimeZone;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract int getRawOffset();
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getID()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.TimeZone.staticClass, "getID", "()Ljava/lang/String;", ref global::java.util.TimeZone._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool hasSameRules(java.util.TimeZone arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z", ref global::java.util.TimeZone._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract void setRawOffset(int arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setID(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TimeZone.staticClass, "setID", "(Ljava/lang/String;)V", ref global::java.util.TimeZone._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getDSTSavings()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TimeZone.staticClass, "getDSTSavings", "()I", ref global::java.util.TimeZone._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract bool useDaylightTime();
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract bool inDaylightTime(java.util.Date arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.lang.String[] getAvailableIDs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimeZone._m18.native == global::System.IntPtr.Zero)
				global::java.util.TimeZone._m18 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._m18)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.lang.String[] getAvailableIDs(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimeZone._m19.native == global::System.IntPtr.Zero)
				global::java.util.TimeZone._m19 = @__env.GetStaticMethodIDNoThrow(global::java.util.TimeZone.staticClass, "getAvailableIDs", "(I)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.TimeZone.staticClass, global::java.util.TimeZone._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public TimeZone() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimeZone._m20.native == global::System.IntPtr.Zero)
				global::java.util.TimeZone._m20 = @__env.GetMethodIDNoThrow(global::java.util.TimeZone.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimeZone.staticClass, global::java.util.TimeZone._m20);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TimeZone_.staticClass, "getOffset", "(IIIIII)I", ref global::java.util.TimeZone_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getRawOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.TimeZone_.staticClass, "getRawOffset", "()I", ref global::java.util.TimeZone_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setRawOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TimeZone_.staticClass, "setRawOffset", "(I)V", ref global::java.util.TimeZone_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool useDaylightTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TimeZone_.staticClass, "useDaylightTime", "()Z", ref global::java.util.TimeZone_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool inDaylightTime(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TimeZone_.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z", ref global::java.util.TimeZone_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static TimeZone_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimeZone_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimeZone"));
		}
		internal static void InitJNI()
		{
		}
	}
}
