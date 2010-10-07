namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ETC1Util : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ETC1Util()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.ETC1Util), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.ETC1Util(@__env);
			}
		}
		protected ETC1Util(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class ETC1Texture : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static ETC1Texture()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.ETC1Util.ETC1Texture), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.opengl.ETC1Util.ETC1Texture(@__env);
				}
			}
			protected ETC1Texture(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getData5273;
			public virtual global::java.nio.ByteBuffer getData() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::android.opengl.ETC1Util.ETC1Texture._getData5273));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._getData5273));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getWidth5274;
			public virtual int getWidth() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.opengl.ETC1Util.ETC1Texture._getWidth5274);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._getWidth5274);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getHeight5275;
			public virtual int getHeight() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.opengl.ETC1Util.ETC1Texture._getHeight5275);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._getHeight5275);
			}
			internal static global::net.sf.jni4net.jni.MethodId _ETC1Texture5276;
			public ETC1Texture(int arg0, int arg1, java.nio.ByteBuffer arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.opengl.ETC1Util.ETC1Texture.staticClass, global::android.opengl.ETC1Util.ETC1Texture._ETC1Texture5276, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.opengl.ETC1Util.ETC1Texture.staticClass = @__class;
				global::android.opengl.ETC1Util.ETC1Texture._getData5273 = @__env.GetMethodID(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "getData", "()Ljava/nio/ByteBuffer;");
				global::android.opengl.ETC1Util.ETC1Texture._getWidth5274 = @__env.GetMethodID(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "getWidth", "()I");
				global::android.opengl.ETC1Util.ETC1Texture._getHeight5275 = @__env.GetMethodID(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "getHeight", "()I");
				global::android.opengl.ETC1Util.ETC1Texture._ETC1Texture5276 = @__env.GetMethodID(global::android.opengl.ETC1Util.ETC1Texture.staticClass, "<init>", "(IILjava/nio/ByteBuffer;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadTexture5277;
		public static void loadTexture(int arg0, int arg1, int arg2, int arg3, int arg4, java.io.InputStream arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._loadTexture5277, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadTexture5278;
		public static void loadTexture(int arg0, int arg1, int arg2, int arg3, int arg4, android.opengl.ETC1Util.ETC1Texture arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._loadTexture5278, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isETC1Supported5279;
		public static bool isETC1Supported() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._isETC1Supported5279);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createTexture5280;
		public static global::android.opengl.ETC1Util.ETC1Texture createTexture(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.opengl.ETC1Util.ETC1Texture>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._createTexture5280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compressTexture5281;
		public static global::android.opengl.ETC1Util.ETC1Texture compressTexture(java.nio.Buffer arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.opengl.ETC1Util.ETC1Texture>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._compressTexture5281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeTexture5282;
		public static void writeTexture(android.opengl.ETC1Util.ETC1Texture arg0, java.io.OutputStream arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._writeTexture5282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ETC1Util5283;
		public ETC1Util()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.ETC1Util.staticClass, global::android.opengl.ETC1Util._ETC1Util5283, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.ETC1Util.staticClass = @__class;
			global::android.opengl.ETC1Util._loadTexture5277 = @__env.GetStaticMethodID(global::android.opengl.ETC1Util.staticClass, "loadTexture", "(IIIIILjava/io/InputStream;)V");
			global::android.opengl.ETC1Util._loadTexture5278 = @__env.GetStaticMethodID(global::android.opengl.ETC1Util.staticClass, "loadTexture", "(IIIIILandroid/opengl/ETC1Util$ETC1Texture;)V");
			global::android.opengl.ETC1Util._isETC1Supported5279 = @__env.GetStaticMethodID(global::android.opengl.ETC1Util.staticClass, "isETC1Supported", "()Z");
			global::android.opengl.ETC1Util._createTexture5280 = @__env.GetStaticMethodID(global::android.opengl.ETC1Util.staticClass, "createTexture", "(Ljava/io/InputStream;)Landroid/opengl/ETC1Util$ETC1Texture;");
			global::android.opengl.ETC1Util._compressTexture5281 = @__env.GetStaticMethodID(global::android.opengl.ETC1Util.staticClass, "compressTexture", "(Ljava/nio/Buffer;IIII)Landroid/opengl/ETC1Util$ETC1Texture;");
			global::android.opengl.ETC1Util._writeTexture5282 = @__env.GetStaticMethodID(global::android.opengl.ETC1Util.staticClass, "writeTexture", "(Landroid/opengl/ETC1Util$ETC1Texture;Ljava/io/OutputStream;)V");
			global::android.opengl.ETC1Util._ETC1Util5283 = @__env.GetMethodID(global::android.opengl.ETC1Util.staticClass, "<init>", "()V");
		}
	}
}
