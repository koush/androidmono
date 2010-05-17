namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Movie : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Movie() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Movie), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque2814; 
		public virtual bool isOpaque() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallBooleanMethod(this, _isOpaque2814); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Movie.staticClass, _isOpaque2814); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime2815; 
		public virtual bool setTime(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallBooleanMethod(this, _setTime2815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Movie.staticClass, _setTime2815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duration2816; 
		public virtual int duration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallIntMethod(this, _duration2816); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Movie.staticClass, _duration2816); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _height2817; 
		public virtual int height() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallIntMethod(this, _height2817); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Movie.staticClass, _height2817); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _width2818; 
		public virtual int width() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				return @__env.CallIntMethod(this, _width2818); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Movie.staticClass, _width2818); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw2819; 
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				@__env.CallVoidMethod(this, _draw2819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Movie.staticClass, _draw2819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw2820; 
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Movie)) 
				@__env.CallVoidMethod(this, _draw2820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Movie.staticClass, _draw2820, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream2821; 
		public static android.graphics.Movie decodeStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, _decodeStream2821, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray2822; 
		public static android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, _decodeByteArray2822, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile2823; 
		public static android.graphics.Movie decodeFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, _decodeFile2823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Movie.staticClass = @__class; 
			global::android.graphics.Movie._isOpaque2814 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "isOpaque", "()Z"); 
			global::android.graphics.Movie._setTime2815 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "setTime", "(I)Z"); 
			global::android.graphics.Movie._duration2816 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "duration", "()I"); 
			global::android.graphics.Movie._height2817 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "height", "()I"); 
			global::android.graphics.Movie._width2818 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "width", "()I"); 
			global::android.graphics.Movie._draw2819 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V"); 
			global::android.graphics.Movie._draw2820 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V"); 
			global::android.graphics.Movie._decodeStream2821 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;"); 
			global::android.graphics.Movie._decodeByteArray2822 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;"); 
			global::android.graphics.Movie._decodeFile2823 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;"); 
		} 
	} 
} 
