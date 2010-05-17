namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GestureStroke : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureStroke() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureStroke), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.gesture.GestureStroke(@__env); 
			} 
		} 
		protected GestureStroke(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath2484; 
		public virtual android.graphics.Path getPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStroke)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _getPath2484)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureStroke.staticClass, _getPath2484)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toPath2485; 
		public virtual android.graphics.Path toPath(float arg0, float arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStroke)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _toPath2485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureStroke.staticClass, _toPath2485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearPath2486; 
		public virtual void clearPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStroke)) 
				@__env.CallVoidMethod(this, _clearPath2486); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureStroke.staticClass, _clearPath2486); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeOrientedBoundingBox2487; 
		public virtual android.gesture.OrientedBoundingBox computeOrientedBoundingBox() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureStroke)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.OrientedBoundingBox>(@__env, @__env.CallObjectMethodPtr(this, _computeOrientedBoundingBox2487)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.OrientedBoundingBox>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureStroke.staticClass, _computeOrientedBoundingBox2487)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureStroke2488; 
		public GestureStroke(java.util.ArrayList arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureStroke.staticClass, _GestureStroke2488, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _boundingBox2489; 
		public android.graphics.RectF boundingBox
		{ 
			get 
			{ 
				return default(android.graphics.RectF); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _length2490; 
		public float length
		{ 
			get 
			{ 
				return default(float); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _points2491; 
		public float[] points
		{ 
			get 
			{ 
				return default(float[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GestureStroke.staticClass = @__class; 
			global::android.gesture.GestureStroke._getPath2484 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "getPath", "()Landroid/graphics/Path;"); 
			global::android.gesture.GestureStroke._toPath2485 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "toPath", "(FFI)Landroid/graphics/Path;"); 
			global::android.gesture.GestureStroke._clearPath2486 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "clearPath", "()V"); 
			global::android.gesture.GestureStroke._computeOrientedBoundingBox2487 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;"); 
			global::android.gesture.GestureStroke._GestureStroke2488 = @__env.GetMethodID(global::android.gesture.GestureStroke.staticClass, "<init>", "(Ljava/util/ArrayList;)V"); 
		} 
	} 
} 
