namespace android.graphics.drawable.shapes
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RoundRectShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::java.lang.Class staticClass;
		static RoundRectShape()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.shapes.RoundRectShape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.shapes.RoundRectShape(@__env);
			}
		}
		protected RoundRectShape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone4040;
		public virtual new global::android.graphics.drawable.shapes.RoundRectShape clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RoundRectShape>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.shapes.RoundRectShape._clone4040));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RoundRectShape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._clone4040));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw4041;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.RoundRectShape._draw4041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._draw4041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResize4042;
		protected override void onResize(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.RoundRectShape._onResize4042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._onResize4042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RoundRectShape4043;
		public RoundRectShape(float[] arg0, android.graphics.RectF arg1, float[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._RoundRectShape4043, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.shapes.RoundRectShape.staticClass = @__class;
			global::android.graphics.drawable.shapes.RoundRectShape._clone4040 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RoundRectShape;");
			global::android.graphics.drawable.shapes.RoundRectShape._draw4041 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.RoundRectShape._onResize4042 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.RoundRectShape._RoundRectShape4043 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "<init>", "([FLandroid/graphics/RectF;[F)V");
		}
	}
}
