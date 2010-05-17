namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LayerRasterizer : android.graphics.Rasterizer
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LayerRasterizer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.LayerRasterizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.LayerRasterizer(@__env); 
			} 
		} 
		protected LayerRasterizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLayer2752; 
		public virtual void addLayer(android.graphics.Paint arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.LayerRasterizer)) 
				@__env.CallVoidMethod(this, _addLayer2752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.LayerRasterizer.staticClass, _addLayer2752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addLayer2753; 
		public virtual void addLayer(android.graphics.Paint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.LayerRasterizer)) 
				@__env.CallVoidMethod(this, _addLayer2753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.LayerRasterizer.staticClass, _addLayer2753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayerRasterizer2754; 
		public LayerRasterizer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.LayerRasterizer.staticClass, _LayerRasterizer2754, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.LayerRasterizer.staticClass = @__class; 
			global::android.graphics.LayerRasterizer._addLayer2752 = @__env.GetMethodID(global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;FF)V"); 
			global::android.graphics.LayerRasterizer._addLayer2753 = @__env.GetMethodID(global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;)V"); 
			global::android.graphics.LayerRasterizer._LayerRasterizer2754 = @__env.GetMethodID(global::android.graphics.LayerRasterizer.staticClass, "<init>", "()V"); 
		} 
	} 
} 
