namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GregorianCalendar : java.util.Calendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GregorianCalendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "add", "(II)V", ref global::java.util.GregorianCalendar._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.GregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.GregorianCalendar._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "hashCode", "()I", ref global::java.util.GregorianCalendar._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.GregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.GregorianCalendar._m3) as java.lang.Object;
		}
		public new global::java.util.TimeZone TimeZone
		{
			get
			{
				return getTimeZone();
			}
			set
			{
				setTimeZone(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.util.TimeZone getTimeZone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.GregorianCalendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;", ref global::java.util.GregorianCalendar._m4) as java.util.TimeZone;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setTimeZone(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V", ref global::java.util.GregorianCalendar._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isLeapYear(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.GregorianCalendar.staticClass, "isLeapYear", "(I)Z", ref global::java.util.GregorianCalendar._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void computeTime()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "computeTime", "()V", ref global::java.util.GregorianCalendar._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void computeFields()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "computeFields", "()V", ref global::java.util.GregorianCalendar._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void roll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "roll", "(II)V", ref global::java.util.GregorianCalendar._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void roll(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "roll", "(IZ)V", ref global::java.util.GregorianCalendar._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int getMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getMinimum", "(I)I", ref global::java.util.GregorianCalendar._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getMaximum", "(I)I", ref global::java.util.GregorianCalendar._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getGreatestMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getGreatestMinimum", "(I)I", ref global::java.util.GregorianCalendar._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override int getLeastMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getLeastMaximum", "(I)I", ref global::java.util.GregorianCalendar._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override int getActualMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getActualMinimum", "(I)I", ref global::java.util.GregorianCalendar._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override int getActualMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.GregorianCalendar.staticClass, "getActualMaximum", "(I)I", ref global::java.util.GregorianCalendar._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setGregorianChange(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.GregorianCalendar.staticClass, "setGregorianChange", "(Ljava/util/Date;)V", ref global::java.util.GregorianCalendar._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Date GregorianChange
		{
			get
			{
				return getGregorianChange();
			}
			set
			{
				setGregorianChange(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.util.Date getGregorianChange()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.GregorianCalendar.staticClass, "getGregorianChange", "()Ljava/util/Date;", ref global::java.util.GregorianCalendar._m18) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public GregorianCalendar() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m19.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m19 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m19);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public GregorianCalendar(java.util.TimeZone arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m20.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m20 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public GregorianCalendar(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m21.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m21 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public GregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m22.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m22 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public GregorianCalendar(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m23.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m23 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m24.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m24 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public GregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.GregorianCalendar._m25.native == global::System.IntPtr.Zero)
				global::java.util.GregorianCalendar._m25 = @__env.GetMethodIDNoThrow(global::java.util.GregorianCalendar.staticClass, "<init>", "(IIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.GregorianCalendar.staticClass, global::java.util.GregorianCalendar._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int BC
		{
			get
			{
				return 0;
			}
		}
		public static int AD
		{
			get
			{
				return 1;
			}
		}
		static GregorianCalendar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.GregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/GregorianCalendar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
