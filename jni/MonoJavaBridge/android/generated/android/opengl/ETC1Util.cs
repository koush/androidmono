namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ETC1Util : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ETC1Util()
		{
			InitJNI();
		}
		protected ETC1Util(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ETC1Texture : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ETC1Texture()
			{
				InitJNI();
			}
			protected ETC1Texture(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new global::java.nio.ByteBuffer Data
			{
				get
				{
					return getData();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getData8132;
			public virtual global::java.nio.ByteBuffer getData()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.ETC1Util.ETC1Texture._getData8132)) as java.nio.ByteBuffer;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._getData8132)) as java.nio.ByteBuffer;
			}
			public new int Width
			{
				get
				{
					return getWidth();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWidth8133;
			public virtual int getWidth()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.opengl.ETC1Util.ETC1Texture._getWidth8133);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._getWidth8133);
			}
			public new int Height
			{
				get
				{
					return getHeight();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHeight8134;
			public virtual int getHeight()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.opengl.ETC1Util.ETC1Texture._getHeight8134);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._getHeight8134);
			}
			internal static global::MonoJavaBridge.MethodId _ETC1Texture8135;
			public ETC1Texture(int arg0, int arg1, java.nio.ByteBuffer arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._ETC1Texture8135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.ETC1Util.ETC1Texture.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/ETC1Util$ETC1Texture"));
				global::android.opengl.ETC1Util.ETC1Texture._getData8132 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "getData", "()Ljava/nio/ByteBuffer;");
				global::android.opengl.ETC1Util.ETC1Texture._getWidth8133 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "getWidth", "()I");
				global::android.opengl.ETC1Util.ETC1Texture._getHeight8134 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "getHeight", "()I");
				global::android.opengl.ETC1Util.ETC1Texture._ETC1Texture8135 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "<init>", "(IILjava/nio/ByteBuffer;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _loadTexture8136;
		public static void loadTexture(int arg0, int arg1, int arg2, int arg3, int arg4, java.io.InputStream arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._loadTexture8136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _loadTexture8137;
		public static void loadTexture(int arg0, int arg1, int arg2, int arg3, int arg4, android.opengl.ETC1Util.ETC1Texture arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._loadTexture8137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _isETC1Supported8138;
		public static bool isETC1Supported()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._isETC1Supported8138);
		}
		internal static global::MonoJavaBridge.MethodId _createTexture8139;
		public static global::android.opengl.ETC1Util.ETC1Texture createTexture(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._createTexture8139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.opengl.ETC1Util.ETC1Texture;
		}
		internal static global::MonoJavaBridge.MethodId _compressTexture8140;
		public static global::android.opengl.ETC1Util.ETC1Texture compressTexture(java.nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._compressTexture8140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.opengl.ETC1Util.ETC1Texture;
		}
		internal static global::MonoJavaBridge.MethodId _writeTexture8141;
		public static void writeTexture(android.opengl.ETC1Util.ETC1Texture arg0, java.io.OutputStream arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._writeTexture8141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ETC1Util8142;
		public ETC1Util() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._ETC1Util8142);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.ETC1Util.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/ETC1Util"));
			global::android.opengl.ETC1Util._loadTexture8136 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "loadTexture", "(IIIIILjava/io/InputStream;)V");
			global::android.opengl.ETC1Util._loadTexture8137 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "loadTexture", "(IIIIILandroid/opengl/ETC1Util$ETC1Texture;)V");
			global::android.opengl.ETC1Util._isETC1Supported8138 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "isETC1Supported", "()Z");
			global::android.opengl.ETC1Util._createTexture8139 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "createTexture", "(Ljava/io/InputStream;)Landroid/opengl/ETC1Util$ETC1Texture;");
			global::android.opengl.ETC1Util._compressTexture8140 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "compressTexture", "(Ljava/nio/Buffer;IIII)Landroid/opengl/ETC1Util$ETC1Texture;");
			global::android.opengl.ETC1Util._writeTexture8141 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "writeTexture", "(Landroid/opengl/ETC1Util$ETC1Texture;Ljava/io/OutputStream;)V");
			global::android.opengl.ETC1Util._ETC1Util8142 = @__env.GetMethodIDNoThrow(global::android.opengl.ETC1Util.staticClass, "<init>", "()V");
		}
	}
}
