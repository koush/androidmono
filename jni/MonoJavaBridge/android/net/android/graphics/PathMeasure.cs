namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PathMeasure : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PathMeasure() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PathMeasure), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PathMeasure(@__env); 
			} 
		} 
		protected PathMeasure(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLength3210; 
		public virtual float getLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				return @__env.CallFloatMethod(this, _getLength3210); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.PathMeasure.staticClass, _getLength3210); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed3211; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				return @__env.CallBooleanMethod(this, _isClosed3211); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.PathMeasure.staticClass, _isClosed3211); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix3212; 
		public virtual bool getMatrix(float arg0, android.graphics.Matrix arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				return @__env.CallBooleanMethod(this, _getMatrix3212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.PathMeasure.staticClass, _getMatrix3212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPath3213; 
		public virtual void setPath(android.graphics.Path arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				@__env.CallVoidMethod(this, _setPath3213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.PathMeasure.staticClass, _setPath3213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosTan3214; 
		public virtual bool getPosTan(float arg0, float[] arg1, float[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				return @__env.CallBooleanMethod(this, _getPosTan3214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.PathMeasure.staticClass, _getPosTan3214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSegment3215; 
		public virtual bool getSegment(float arg0, float arg1, android.graphics.Path arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				return @__env.CallBooleanMethod(this, _getSegment3215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.PathMeasure.staticClass, _getSegment3215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextContour3216; 
		public virtual bool nextContour() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.PathMeasure)) 
				return @__env.CallBooleanMethod(this, _nextContour3216); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.PathMeasure.staticClass, _nextContour3216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PathMeasure3217; 
		public PathMeasure()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PathMeasure.staticClass, _PathMeasure3217, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PathMeasure3218; 
		public PathMeasure(android.graphics.Path arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PathMeasure.staticClass, _PathMeasure3218, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		public static int POSITION_MATRIX_FLAG
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int TANGENT_MATRIX_FLAG
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PathMeasure.staticClass = @__class; 
			global::android.graphics.PathMeasure._getLength3210 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "getLength", "()F"); 
			global::android.graphics.PathMeasure._isClosed3211 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "isClosed", "()Z"); 
			global::android.graphics.PathMeasure._getMatrix3212 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "getMatrix", "(FLandroid/graphics/Matrix;I)Z"); 
			global::android.graphics.PathMeasure._setPath3213 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "setPath", "(Landroid/graphics/Path;Z)V"); 
			global::android.graphics.PathMeasure._getPosTan3214 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "getPosTan", "(F[F[F)Z"); 
			global::android.graphics.PathMeasure._getSegment3215 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "getSegment", "(FFLandroid/graphics/Path;Z)Z"); 
			global::android.graphics.PathMeasure._nextContour3216 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "nextContour", "()Z"); 
			global::android.graphics.PathMeasure._PathMeasure3217 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "<init>", "()V"); 
			global::android.graphics.PathMeasure._PathMeasure3218 = @__env.GetMethodID(global::android.graphics.PathMeasure.staticClass, "<init>", "(Landroid/graphics/Path;Z)V"); 
		} 
	} 
} 
