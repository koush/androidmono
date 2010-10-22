namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Timestamp : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Timestamp()
		{
			InitJNI();
		}
		protected Timestamp(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals24988;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Timestamp._equals24988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._equals24988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals24989;
		public virtual bool equals(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Timestamp._equals24989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._equals24989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString24990;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Timestamp._toString24990)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._toString24990)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo24991;
		public virtual int compareTo(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Timestamp._compareTo24991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._compareTo24991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo24992;
		public override int compareTo(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Timestamp._compareTo24992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._compareTo24992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf24993;
		public static global::java.sql.Timestamp valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Timestamp.staticClass, global::java.sql.Timestamp._valueOf24993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _after24994;
		public virtual bool after(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Timestamp._after24994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._after24994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before24995;
		public virtual bool before(java.sql.Timestamp arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Timestamp._before24995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._before24995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24996;
		public override void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Timestamp._setTime24996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._setTime24996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Time
		{
			get
			{
				return getTime();
			}
			set
			{
				setTime(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTime24997;
		public override long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Timestamp._getTime24997);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._getTime24997);
		}
		public new int Nanos
		{
			get
			{
				return getNanos();
			}
			set
			{
				setNanos(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNanos24998;
		public virtual int getNanos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Timestamp._getNanos24998);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._getNanos24998);
		}
		internal static global::MonoJavaBridge.MethodId _setNanos24999;
		public virtual void setNanos(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Timestamp._setNanos24999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Timestamp.staticClass, global::java.sql.Timestamp._setNanos24999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Timestamp25000;
		public Timestamp(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Timestamp.staticClass, global::java.sql.Timestamp._Timestamp25000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timestamp25001;
		public Timestamp(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Timestamp.staticClass, global::java.sql.Timestamp._Timestamp25001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Timestamp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Timestamp"));
			global::java.sql.Timestamp._equals24988 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.sql.Timestamp._equals24989 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "equals", "(Ljava/sql/Timestamp;)Z");
			global::java.sql.Timestamp._toString24990 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "toString", "()Ljava/lang/String;");
			global::java.sql.Timestamp._compareTo24991 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "compareTo", "(Ljava/sql/Timestamp;)I");
			global::java.sql.Timestamp._compareTo24992 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "compareTo", "(Ljava/util/Date;)I");
			global::java.sql.Timestamp._valueOf24993 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::java.sql.Timestamp._after24994 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "after", "(Ljava/sql/Timestamp;)Z");
			global::java.sql.Timestamp._before24995 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "before", "(Ljava/sql/Timestamp;)Z");
			global::java.sql.Timestamp._setTime24996 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "setTime", "(J)V");
			global::java.sql.Timestamp._getTime24997 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "getTime", "()J");
			global::java.sql.Timestamp._getNanos24998 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "getNanos", "()I");
			global::java.sql.Timestamp._setNanos24999 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "setNanos", "(I)V");
			global::java.sql.Timestamp._Timestamp25000 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "<init>", "(J)V");
			global::java.sql.Timestamp._Timestamp25001 = @__env.GetMethodIDNoThrow(global::java.sql.Timestamp.staticClass, "<init>", "(IIIIIII)V");
		}
	}
}
