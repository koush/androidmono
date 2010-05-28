namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Movie : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Movie() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Movie), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Movie(@__env); 
			} 
		} 
		protected Movie(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque3014; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Movie._isOpaque3014); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._isOpaque3014); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime3015; 
		public virtual bool setTime(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Movie._setTime3015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._setTime3015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duration3016; 
		public virtual int duration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallIntMethod(this, global::android.graphics.Movie._duration3016); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._duration3016); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _height3017; 
		public virtual int height() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallIntMethod(this, global::android.graphics.Movie._height3017); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._height3017); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _width3018; 
		public virtual int width() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallIntMethod(this, global::android.graphics.Movie._width3018); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._width3018); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3019; 
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				@__env.CallVoidMethod(this, global::android.graphics.Movie._draw3019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw3019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3020; 
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				@__env.CallVoidMethod(this, global::android.graphics.Movie._draw3020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw3020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream3021; 
		public static global::android.graphics.Movie decodeStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeStream3021, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray3022; 
		public static global::android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeByteArray3022, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile3023; 
		public static global::android.graphics.Movie decodeFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeFile3023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Movie.staticClass = @__class; 
			global::android.graphics.Movie._isOpaque3014 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "isOpaque", "()Z"); 
			global::android.graphics.Movie._setTime3015 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "setTime", "(I)Z"); 
			global::android.graphics.Movie._duration3016 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "duration", "()I"); 
			global::android.graphics.Movie._height3017 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "height", "()I"); 
			global::android.graphics.Movie._width3018 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "width", "()I"); 
			global::android.graphics.Movie._draw3019 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V"); 
			global::android.graphics.Movie._draw3020 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Movie._decodeStream3021 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;"); 
			global::android.graphics.Movie._decodeByteArray3022 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;"); 
			global::android.graphics.Movie._decodeFile3023 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;"); 
		} 
	} 
} 
