namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RegionIterator : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static RegionIterator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.RegionIterator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.RegionIterator(@__env); 
			} 
		} 
		protected RegionIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _next3204; 
		public virtual bool next(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.RegionIterator)) 
				return @__env.CallBooleanMethod(this, _next3204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.RegionIterator.staticClass, _next3204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RegionIterator3205; 
		public RegionIterator(android.graphics.Region arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.RegionIterator.staticClass, _RegionIterator3205, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.RegionIterator.staticClass = @__class; 
			global::android.graphics.RegionIterator._next3204 = @__env.GetMethodID(global::android.graphics.RegionIterator.staticClass, "next", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.RegionIterator._RegionIterator3205 = @__env.GetMethodID(global::android.graphics.RegionIterator.staticClass, "<init>", "(Landroid/graphics/Region;)V"); 
		} 
	} 
} 
