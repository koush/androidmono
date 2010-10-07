namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PointF : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PointF()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.PointF), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.PointF(@__env);
			}
		}
		protected PointF(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3445;
		public virtual bool equals(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.PointF._equals3445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._equals3445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offset3446;
		public virtual void offset(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.PointF._offset3446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._offset3446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length3447;
		public static float length(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.graphics.PointF.staticClass, global::android.graphics.PointF._length3447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length3448;
		public virtual float length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.PointF._length3448);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._length3448);
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3449;
		public virtual void set(android.graphics.PointF arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.PointF._set3449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set3449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3450;
		public virtual void set(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.PointF._set3450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._set3450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _negate3451;
		public virtual void negate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.PointF._negate3451);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.PointF.staticClass, global::android.graphics.PointF._negate3451);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PointF3452;
		public PointF(float arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF3452, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PointF3453;
		public PointF(android.graphics.Point arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF3453, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PointF3454;
		public PointF()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.PointF.staticClass, global::android.graphics.PointF._PointF3454, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _x3455;
		public float x
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _y3456;
		public float y
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.PointF.staticClass = @__class;
			global::android.graphics.PointF._equals3445 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "equals", "(FF)Z");
			global::android.graphics.PointF._offset3446 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "offset", "(FF)V");
			global::android.graphics.PointF._length3447 = @__env.GetStaticMethodID(global::android.graphics.PointF.staticClass, "length", "(FF)F");
			global::android.graphics.PointF._length3448 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "length", "()F");
			global::android.graphics.PointF._set3449 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "set", "(Landroid/graphics/PointF;)V");
			global::android.graphics.PointF._set3450 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "set", "(FF)V");
			global::android.graphics.PointF._negate3451 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "negate", "()V");
			global::android.graphics.PointF._PointF3452 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "<init>", "(FF)V");
			global::android.graphics.PointF._PointF3453 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::android.graphics.PointF._PointF3454 = @__env.GetMethodID(global::android.graphics.PointF.staticClass, "<init>", "()V");
		}
	}
}
