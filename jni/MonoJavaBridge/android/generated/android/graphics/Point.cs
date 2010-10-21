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
		internal static global::MonoJavaBridge.MethodId _equals5600;
		public virtual bool equals(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Point._equals5600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals5600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals5601;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Point._equals5601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals5601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString5602;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Point._toString5602)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._toString5602)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode5603;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Point._hashCode5603);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._hashCode5603);
		}
		internal static global::MonoJavaBridge.MethodId _offset5604;
		public virtual void offset(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Point._offset5604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._offset5604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5605;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Point._set5605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._set5605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _negate5606;
		public virtual void negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Point._negate5606);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Point.staticClass, global::android.graphics.Point._negate5606);
		}
		internal static global::MonoJavaBridge.MethodId _Point5607;
		public Point(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point5607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Point5608;
		public Point(android.graphics.Point arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point5608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Point5609;
		public Point()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point5609);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x5610;
		public int x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _x5610);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y5611;
		public int y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _y5611);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Point.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Point"));
			global::android.graphics.Point._equals5600 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "equals", "(II)Z");
			global::android.graphics.Point._equals5601 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Point._toString5602 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Point._hashCode5603 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "hashCode", "()I");
			global::android.graphics.Point._offset5604 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "offset", "(II)V");
			global::android.graphics.Point._set5605 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "set", "(II)V");
			global::android.graphics.Point._negate5606 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "negate", "()V");
			global::android.graphics.Point._Point5607 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(II)V");
			global::android.graphics.Point._Point5608 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::android.graphics.Point._Point5609 = @__env.GetMethodIDNoThrow(global::android.graphics.Point.staticClass, "<init>", "()V");
			global::android.graphics.Point._x5610 = @__env.GetFieldIDNoThrow(global::android.graphics.Point.staticClass, "x", "I");
			global::android.graphics.Point._y5611 = @__env.GetFieldIDNoThrow(global::android.graphics.Point.staticClass, "y", "I");
		}
	}
}
