namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PointF : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PointF()
		{
			InitJNI();
		}
		protected PointF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals5612;
		public virtual bool equals(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.PointF._equals5612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._equals5612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _offset5613;
		public virtual void offset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._offset5613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._offset5613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length5614;
		public static float length(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.graphics.PointF.staticClass, global::android.graphics.PointF._length5614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length5615;
		public virtual float length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.PointF._length5615);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._length5615);
		}
		internal static global::MonoJavaBridge.MethodId _set5616;
		public virtual void set(android.graphics.PointF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._set5616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set5616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5617;
		public virtual void set(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._set5617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set5617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _negate5618;
		public virtual void negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.PointF._negate5618);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._negate5618);
		}
		internal static global::MonoJavaBridge.MethodId _PointF5619;
		public PointF(float arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF5619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PointF5620;
		public PointF(android.graphics.Point arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF5620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PointF5621;
		public PointF()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF5621);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x5622;
		public float x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _x5622);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y5623;
		public float y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _y5623);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PointF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PointF"));
			global::android.graphics.PointF._equals5612 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "equals", "(FF)Z");
			global::android.graphics.PointF._offset5613 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "offset", "(FF)V");
			global::android.graphics.PointF._length5614 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "(FF)F");
			global::android.graphics.PointF._length5615 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "length", "()F");
			global::android.graphics.PointF._set5616 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "set", "(Landroid/graphics/PointF;)V");
			global::android.graphics.PointF._set5617 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "set", "(FF)V");
			global::android.graphics.PointF._negate5618 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "negate", "()V");
			global::android.graphics.PointF._PointF5619 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(FF)V");
			global::android.graphics.PointF._PointF5620 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::android.graphics.PointF._PointF5621 = @__env.GetMethodIDNoThrow(global::android.graphics.PointF.staticClass, "<init>", "()V");
			global::android.graphics.PointF._x5622 = @__env.GetFieldIDNoThrow(global::android.graphics.PointF.staticClass, "x", "F");
			global::android.graphics.PointF._y5623 = @__env.GetFieldIDNoThrow(global::android.graphics.PointF.staticClass, "y", "F");
		}
	}
}
