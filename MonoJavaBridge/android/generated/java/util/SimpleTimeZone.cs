namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleTimeZone : java.util.TimeZone
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleTimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals26732;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.SimpleTimeZone._equals26732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26733;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.SimpleTimeZone.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.SimpleTimeZone._toString26733) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26734;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "hashCode", "()I", ref global::java.util.SimpleTimeZone._hashCode26734);
		}
		internal static global::MonoJavaBridge.MethodId _clone26735;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SimpleTimeZone.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.SimpleTimeZone._clone26735) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26736;
		public override int getOffset(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getOffset", "(J)I", ref global::java.util.SimpleTimeZone._getOffset26736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffset26737;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getOffset", "(IIIIII)I", ref global::java.util.SimpleTimeZone._getOffset26737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public new int RawOffset
		{
			get
			{
				return getRawOffset();
			}
			set
			{
				setRawOffset(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawOffset26738;
		public override int getRawOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getRawOffset", "()I", ref global::java.util.SimpleTimeZone._getRawOffset26738);
		}
		internal static global::MonoJavaBridge.MethodId _hasSameRules26739;
		public override bool hasSameRules(java.util.TimeZone arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z", ref global::java.util.SimpleTimeZone._hasSameRules26739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRawOffset26740;
		public override void setRawOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setRawOffset", "(I)V", ref global::java.util.SimpleTimeZone._setRawOffset26740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DSTSavings
		{
			get
			{
				return getDSTSavings();
			}
			set
			{
				setDSTSavings(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDSTSavings26741;
		public override int getDSTSavings()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getDSTSavings", "()I", ref global::java.util.SimpleTimeZone._getDSTSavings26741);
		}
		internal static global::MonoJavaBridge.MethodId _useDaylightTime26742;
		public override bool useDaylightTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "useDaylightTime", "()Z", ref global::java.util.SimpleTimeZone._useDaylightTime26742);
		}
		internal static global::MonoJavaBridge.MethodId _inDaylightTime26743;
		public override bool inDaylightTime(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z", ref global::java.util.SimpleTimeZone._inDaylightTime26743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int StartYear
		{
			set
			{
				setStartYear(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStartYear26744;
		public virtual void setStartYear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartYear", "(I)V", ref global::java.util.SimpleTimeZone._setStartYear26744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartRule26745;
		public virtual void setStartRule(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(III)V", ref global::java.util.SimpleTimeZone._setStartRule26745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStartRule26746;
		public virtual void setStartRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(IIIIZ)V", ref global::java.util.SimpleTimeZone._setStartRule26746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setStartRule26747;
		public virtual void setStartRule(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(IIII)V", ref global::java.util.SimpleTimeZone._setStartRule26747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setEndRule26748;
		public virtual void setEndRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(IIIIZ)V", ref global::java.util.SimpleTimeZone._setEndRule26748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setEndRule26749;
		public virtual void setEndRule(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(III)V", ref global::java.util.SimpleTimeZone._setEndRule26749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setEndRule26750;
		public virtual void setEndRule(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(IIII)V", ref global::java.util.SimpleTimeZone._setEndRule26750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setDSTSavings26751;
		public virtual void setDSTSavings(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setDSTSavings", "(I)V", ref global::java.util.SimpleTimeZone._setDSTSavings26751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone26752;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._SimpleTimeZone26752.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._SimpleTimeZone26752 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone26752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone26753;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._SimpleTimeZone26753.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._SimpleTimeZone26753 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone26753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone26754;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._SimpleTimeZone26754.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._SimpleTimeZone26754 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone26754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleTimeZone26755;
		public SimpleTimeZone(int arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._SimpleTimeZone26755.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._SimpleTimeZone26755 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._SimpleTimeZone26755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int WALL_TIME
		{
			get
			{
				return 0;
			}
		}
		public static int STANDARD_TIME
		{
			get
			{
				return 1;
			}
		}
		public static int UTC_TIME
		{
			get
			{
				return 2;
			}
		}
		static SimpleTimeZone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SimpleTimeZone.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SimpleTimeZone"));
		}
		internal static void InitJNI()
		{
		}
	}
}
