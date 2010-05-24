namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CharArrayBuffer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CharArrayBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.CharArrayBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.CharArrayBuffer(@__env); 
			} 
		} 
		internal CharArrayBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharArrayBuffer2161; 
		public CharArrayBuffer(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CharArrayBuffer.staticClass, _CharArrayBuffer2161, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharArrayBuffer2162; 
		public CharArrayBuffer(char[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CharArrayBuffer.staticClass, _CharArrayBuffer2162, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _data2163; 
		public char[] data
		{ 
			get 
			{ 
				return default(char[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sizeCopied2164; 
		public int sizeCopied
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
			global::android.database.CharArrayBuffer.staticClass = @__class; 
			global::android.database.CharArrayBuffer._CharArrayBuffer2161 = @__env.GetMethodID(global::android.database.CharArrayBuffer.staticClass, "<init>", "(I)V"); 
			global::android.database.CharArrayBuffer._CharArrayBuffer2162 = @__env.GetMethodID(global::android.database.CharArrayBuffer.staticClass, "<init>", "([C)V"); 
		} 
	} 
} 
