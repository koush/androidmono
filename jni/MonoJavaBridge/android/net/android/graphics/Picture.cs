namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Picture : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Picture() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Picture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _draw3219; 
		public virtual void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				@__env.CallVoidMethod(this, _draw3219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Picture.staticClass, _draw3219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromStream3220; 
		public static android.graphics.Picture createFromStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Picture.staticClass, _createFromStream3220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3221; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				return @__env.CallIntMethod(this, _getWidth3221); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Picture.staticClass, _getWidth3221); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3222; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				return @__env.CallIntMethod(this, _getHeight3222); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Picture.staticClass, _getHeight3222); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginRecording3223; 
		public virtual android.graphics.Canvas beginRecording(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, _beginRecording3223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Picture.staticClass, _beginRecording3223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endRecording3224; 
		public virtual void endRecording() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				@__env.CallVoidMethod(this, _endRecording3224); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Picture.staticClass, _endRecording3224); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToStream3225; 
		public virtual void writeToStream(java.io.OutputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				@__env.CallVoidMethod(this, _writeToStream3225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Picture.staticClass, _writeToStream3225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Picture3226; 
		public Picture()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Picture.staticClass, _Picture3226, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Picture3227; 
		public Picture(android.graphics.Picture arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Picture.staticClass, _Picture3227, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Picture.staticClass = @__class; 
			global::android.graphics.Picture._draw3219 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.Picture._createFromStream3220 = @__env.GetStaticMethodID(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;"); 
			global::android.graphics.Picture._getWidth3221 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "getWidth", "()I"); 
			global::android.graphics.Picture._getHeight3222 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "getHeight", "()I"); 
			global::android.graphics.Picture._beginRecording3223 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;"); 
			global::android.graphics.Picture._endRecording3224 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "endRecording", "()V"); 
			global::android.graphics.Picture._writeToStream3225 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V"); 
			global::android.graphics.Picture._Picture3226 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "<init>", "()V"); 
			global::android.graphics.Picture._Picture3227 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V"); 
		} 
	} 
} 
