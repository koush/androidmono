namespace android.graphics.drawable.shapes 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PathShape : android.graphics.drawable.shapes.Shape
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PathShape() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.shapes.PathShape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.shapes.PathShape(@__env); 
			} 
		} 
		protected PathShape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone3619; 
		public virtual new android.graphics.drawable.shapes.PathShape clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.PathShape)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.PathShape>(@__env, @__env.CallObjectMethodPtr(this, _clone3619)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.PathShape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.shapes.PathShape.staticClass, _clone3619)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3620; 
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.PathShape)) 
				@__env.CallVoidMethod(this, _draw3620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.PathShape.staticClass, _draw3620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResize3621; 
		protected override void onResize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.PathShape)) 
				@__env.CallVoidMethod(this, _onResize3621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.PathShape.staticClass, _onResize3621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PathShape3622; 
		public PathShape(android.graphics.Path arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.shapes.PathShape.staticClass, _PathShape3622, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.shapes.PathShape.staticClass = @__class; 
			global::android.graphics.drawable.shapes.PathShape._clone3619 = @__env.GetMethodID(global::android.graphics.drawable.shapes.PathShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/PathShape;"); 
			global::android.graphics.drawable.shapes.PathShape._draw3620 = @__env.GetMethodID(global::android.graphics.drawable.shapes.PathShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.shapes.PathShape._onResize3621 = @__env.GetMethodID(global::android.graphics.drawable.shapes.PathShape.staticClass, "onResize", "(FF)V"); 
			global::android.graphics.drawable.shapes.PathShape._PathShape3622 = @__env.GetMethodID(global::android.graphics.drawable.shapes.PathShape.staticClass, "<init>", "(Landroid/graphics/Path;FF)V"); 
		} 
	} 
} 
