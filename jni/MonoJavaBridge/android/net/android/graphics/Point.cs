namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Point : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Point() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Point), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode3034; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				return @__env.CallIntMethod(this, _hashCode3034); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Point.staticClass, _hashCode3034); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals3035; 
		public virtual bool equals(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				return @__env.CallBooleanMethod(this, _equals3035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Point.staticClass, _equals3035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals3036; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				return @__env.CallBooleanMethod(this, _equals3036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Point.staticClass, _equals3036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString3037; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString3037)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Point.staticClass, _toString3037)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offset3038; 
		public virtual void offset(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				@__env.CallVoidMethod(this, _offset3038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Point.staticClass, _offset3038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set3039; 
		public virtual void set(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				@__env.CallVoidMethod(this, _set3039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Point.staticClass, _set3039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _negate3040; 
		public virtual void negate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Point)) 
				@__env.CallVoidMethod(this, _negate3040); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Point.staticClass, _negate3040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Point3041; 
		public Point(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Point.staticClass, _Point3041, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Point3042; 
		public Point(android.graphics.Point arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Point.staticClass, _Point3042, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Point3043; 
		public Point()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Point.staticClass, _Point3043, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _x3044; 
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
		internal static global::net.sf.jni4net.jni.FieldId _y3045; 
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
			global::android.graphics.Point._hashCode3034 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "hashCode", "()I"); 
			global::android.graphics.Point._equals3035 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "equals", "(II)Z"); 
			global::android.graphics.Point._equals3036 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.graphics.Point._toString3037 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.graphics.Point._offset3038 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "offset", "(II)V"); 
			global::android.graphics.Point._set3039 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "set", "(II)V"); 
			global::android.graphics.Point._negate3040 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "negate", "()V"); 
			global::android.graphics.Point._Point3041 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "<init>", "(II)V"); 
			global::android.graphics.Point._Point3042 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "<init>", "(Landroid/graphics/Point;)V"); 
			global::android.graphics.Point._Point3043 = @__env.GetMethodID(global::android.graphics.Point.staticClass, "<init>", "()V"); 
		} 
	} 
} 
