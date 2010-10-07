namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Point : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Point()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Point), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Point(@__env);
			}
		}
		protected Point(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3433;
		public virtual bool equals(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Point._equals3433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals3433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals3434;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Point._equals3434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._equals3434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString3435;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Point._toString3435));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._toString3435));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode3436;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Point._hashCode3436);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._hashCode3436);
		}
		internal static global::net.sf.jni4net.jni.MethodId _offset3437;
		public virtual void offset(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Point._offset3437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._offset3437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3438;
		public virtual void set(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Point._set3438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._set3438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _negate3439;
		public virtual void negate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Point._negate3439);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Point.staticClass, global::android.graphics.Point._negate3439);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Point3440;
		public Point(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point3440, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Point3441;
		public Point(android.graphics.Point arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point3441, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Point3442;
		public Point()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Point.staticClass, global::android.graphics.Point._Point3442, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _x3443;
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
		internal static global::net.sf.jni4net.jni.FieldId _y3444;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Point.staticClass = @__class;
			global::android.graphics.Point._equals3433 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "equals", "(II)Z");
			global::android.graphics.Point._equals3434 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Point._toString3435 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.Point._hashCode3436 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "hashCode", "()I");
			global::android.graphics.Point._offset3437 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "offset", "(II)V");
			global::android.graphics.Point._set3438 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "set", "(II)V");
			global::android.graphics.Point._negate3439 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "negate", "()V");
			global::android.graphics.Point._Point3440 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "<init>", "(II)V");
			global::android.graphics.Point._Point3441 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "<init>", "(Landroid/graphics/Point;)V");
			global::android.graphics.Point._Point3442 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "<init>", "()V");
		}
	}
}
