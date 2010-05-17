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
		internal static global::net.sf.jni4net.jni.MethodId _draw3019; 
		public virtual void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				@__env.CallVoidMethod(this, _draw3019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Picture.staticClass, _draw3019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromStream3020; 
		public static android.graphics.Picture createFromStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Picture.staticClass, _createFromStream3020, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3021; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				return @__env.CallIntMethod(this, _getWidth3021); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Picture.staticClass, _getWidth3021); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3022; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				return @__env.CallIntMethod(this, _getHeight3022); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Picture.staticClass, _getHeight3022); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginRecording3023; 
		public virtual android.graphics.Canvas beginRecording(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, _beginRecording3023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Picture.staticClass, _beginRecording3023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endRecording3024; 
		public virtual void endRecording() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				@__env.CallVoidMethod(this, _endRecording3024); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Picture.staticClass, _endRecording3024); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToStream3025; 
		public virtual void writeToStream(java.io.OutputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Picture)) 
				@__env.CallVoidMethod(this, _writeToStream3025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Picture.staticClass, _writeToStream3025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Picture3026; 
		public Picture()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Picture.staticClass, _Picture3026, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Picture3027; 
		public Picture(android.graphics.Picture arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Picture.staticClass, _Picture3027, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Picture.staticClass = @__class; 
			global::android.graphics.Picture._draw3019 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.Picture._createFromStream3020 = @__env.GetStaticMethodID(global::android.graphics.Picture.staticClass, "createFromStream", "(Ljava/io/InputStream;)Landroid/graphics/Picture;"); 
			global::android.graphics.Picture._getWidth3021 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "getWidth", "()I"); 
			global::android.graphics.Picture._getHeight3022 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "getHeight", "()I"); 
			global::android.graphics.Picture._beginRecording3023 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "beginRecording", "(II)Landroid/graphics/Canvas;"); 
			global::android.graphics.Picture._endRecording3024 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "endRecording", "()V"); 
			global::android.graphics.Picture._writeToStream3025 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "writeToStream", "(Ljava/io/OutputStream;)V"); 
			global::android.graphics.Picture._Picture3026 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "<init>", "()V"); 
			global::android.graphics.Picture._Picture3027 = @__env.GetMethodID(global::android.graphics.Picture.staticClass, "<init>", "(Landroid/graphics/Picture;)V"); 
		} 
	} 
} 
