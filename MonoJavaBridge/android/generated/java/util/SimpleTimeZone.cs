namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleTimeZone : java.util.TimeZone
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleTimeZone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.SimpleTimeZone._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.SimpleTimeZone.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.SimpleTimeZone._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "hashCode", "()I", ref global::java.util.SimpleTimeZone._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.SimpleTimeZone.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.SimpleTimeZone._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getOffset(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getOffset", "(J)I", ref global::java.util.SimpleTimeZone._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getOffset(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getOffset", "(IIIIII)I", ref global::java.util.SimpleTimeZone._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getRawOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getRawOffset", "()I", ref global::java.util.SimpleTimeZone._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool hasSameRules(java.util.TimeZone arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "hasSameRules", "(Ljava/util/TimeZone;)Z", ref global::java.util.SimpleTimeZone._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setRawOffset(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setRawOffset", "(I)V", ref global::java.util.SimpleTimeZone._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getDSTSavings()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.SimpleTimeZone.staticClass, "getDSTSavings", "()I", ref global::java.util.SimpleTimeZone._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool useDaylightTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "useDaylightTime", "()Z", ref global::java.util.SimpleTimeZone._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool inDaylightTime(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.SimpleTimeZone.staticClass, "inDaylightTime", "(Ljava/util/Date;)Z", ref global::java.util.SimpleTimeZone._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int StartYear
		{
			set
			{
				setStartYear(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setStartYear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartYear", "(I)V", ref global::java.util.SimpleTimeZone._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setStartRule(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(III)V", ref global::java.util.SimpleTimeZone._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setStartRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(IIIIZ)V", ref global::java.util.SimpleTimeZone._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setStartRule(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setStartRule", "(IIII)V", ref global::java.util.SimpleTimeZone._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setEndRule(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(IIIIZ)V", ref global::java.util.SimpleTimeZone._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setEndRule(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(III)V", ref global::java.util.SimpleTimeZone._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setEndRule(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setEndRule", "(IIII)V", ref global::java.util.SimpleTimeZone._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setDSTSavings(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.SimpleTimeZone.staticClass, "setDSTSavings", "(I)V", ref global::java.util.SimpleTimeZone._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._m20.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._m20 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._m21.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._m21 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public SimpleTimeZone(int arg0, java.lang.String arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._m22.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._m22 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;IIIIIIIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public SimpleTimeZone(int arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.SimpleTimeZone._m23.native == global::System.IntPtr.Zero)
				global::java.util.SimpleTimeZone._m23 = @__env.GetMethodIDNoThrow(global::java.util.SimpleTimeZone.staticClass, "<init>", "(ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.SimpleTimeZone.staticClass, global::java.util.SimpleTimeZone._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
	}
}
