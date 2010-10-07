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
		internal static global::net.sf.jni4net.jni.MethodId _isOpaque3213;
		public virtual bool isOpaque() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Movie._isOpaque3213);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._isOpaque3213);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTime3214;
		public virtual bool setTime(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Movie._setTime3214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._setTime3214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _duration3215;
		public virtual int duration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Movie._duration3215);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._duration3215);
		}
		internal static global::net.sf.jni4net.jni.MethodId _height3216;
		public virtual int height() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Movie._height3216);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._height3216);
		}
		internal static global::net.sf.jni4net.jni.MethodId _width3217;
		public virtual int width() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Movie._width3217);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._width3217);
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3218;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Movie._draw3218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw3218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3219;
		public virtual void draw(android.graphics.Canvas arg0, float arg1, float arg2, android.graphics.Paint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Movie._draw3219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Movie.staticClass, global::android.graphics.Movie._draw3219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream3220;
		public static global::android.graphics.Movie decodeStream(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeStream3220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray3221;
		public static global::android.graphics.Movie decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeByteArray3221, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile3222;
		public static global::android.graphics.Movie decodeFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Movie>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Movie.staticClass, global::android.graphics.Movie._decodeFile3222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Movie.staticClass = @__class;
			global::android.graphics.Movie._isOpaque3213 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "isOpaque", "()Z");
			global::android.graphics.Movie._setTime3214 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "setTime", "(I)Z");
			global::android.graphics.Movie._duration3215 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "duration", "()I");
			global::android.graphics.Movie._height3216 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "height", "()I");
			global::android.graphics.Movie._width3217 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "width", "()I");
			global::android.graphics.Movie._draw3218 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FF)V");
			global::android.graphics.Movie._draw3219 = @__env.GetMethodID(global::android.graphics.Movie.staticClass, "draw", "(Landroid/graphics/Canvas;FFLandroid/graphics/Paint;)V");
			global::android.graphics.Movie._decodeStream3220 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Movie;");
			global::android.graphics.Movie._decodeByteArray3221 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Movie;");
			global::android.graphics.Movie._decodeFile3222 = @__env.GetStaticMethodID(global::android.graphics.Movie.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Movie;");
		}
	}
}
