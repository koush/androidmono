namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Picture : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Picture()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Picture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Picture(@__env);
			}
		}
		protected Picture(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3418;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Picture._draw3418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._draw3418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromStream3419;
		public static global::android.graphics.Picture createFromStream(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Picture.staticClass, global::android.graphics.Picture._createFromStream3419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3420;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Picture._getWidth3420);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getWidth3420);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3421;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Picture._getHeight3421);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._getHeight3421);
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginRecording3422;
		public virtual global::android.graphics.Canvas beginRecording(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Picture._beginRecording3422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._beginRecording3422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _endRecording3423;
		public virtual void endRecording() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Picture._endRecording3423);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._endRecording3423);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToStream3424;
		public virtual void writeToStream(java.io.OutputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Picture._writeToStream3424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Picture.staticClass, global::android.graphics.Picture._writeToStream3424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Picture3425;
		public Picture()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture3425, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Picture3426;
		public Picture(android.graphics.Picture arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.Picture.staticClass, global::android.graphics.Picture._Picture3426, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Picture.staticClass = @__class;
			global::android.graphics.Picture._draw3418 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.Picture._createFromStream3419 = @__env.GetStaticMethodID(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;");
			global::android.graphics.Picture._getWidth3420 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "getWidth", "()I");
			global::android.graphics.Picture._getHeight3421 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "getHeight", "()I");
			global::android.graphics.Picture._beginRecording3422 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;");
			global::android.graphics.Picture._endRecording3423 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "endRecording", "()V");
			global::android.graphics.Picture._writeToStream3424 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V");
			global::android.graphics.Picture._Picture3425 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "<init>", "()V");
			global::android.graphics.Picture._Picture3426 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
		}
	}
}
