namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Point : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Point()
		{
			InitJNI();
		}
		protected Point(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3619;
		public virtual bool equals(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Point._equals3619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals3619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals3620;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Point._equals3620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals3620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString3621;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Point._toString3621)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._toString3621)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode3622;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Point._hashCode3622);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._hashCode3622);
		}
		internal static global::MonoJavaBridge.MethodId _offset3623;
		public virtual void offset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Point._offset3623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._offset3623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set3624;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Point._set3624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._set3624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _negate3625;
		public virtual void negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Point._negate3625);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._negate3625);
		}
		internal static global::MonoJavaBridge.MethodId _Point3626;
		public Point(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point3626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Point3627;
		public Point(android.graphics.Point arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point3627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Point3628;
		public Point()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point3628);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x3629;
		public int x
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y3630;
		public int y
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Point.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Point"));
			global::android.graphics.Point._equals3619 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "equals", "(II)Z");
			global::android.graphics.Point._equals3620 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Point._toString3621 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Point._hashCode3622 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "hashCode", "()I");
			global::android.graphics.Point._offset3623 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "offset", "(II)V");
			global::android.graphics.Point._set3624 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "set", "(II)V");
			global::android.graphics.Point._negate3625 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "negate", "()V");
			global::android.graphics.Point._Point3626 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(II)V");
			global::android.graphics.Point._Point3627 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::android.graphics.Point._Point3628 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "()V");
		}
	}
}
