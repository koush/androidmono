namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Bundle : java.lang.Object, Parcelable, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Bundle() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Bundle), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Bundle(@__env); 
			} 
		} 
		internal Bundle(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get5133; 
		public java.lang.Object get(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get5133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _get5133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone5134; 
		public java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone5134)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _clone5134)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean5135; 
		public bool getBoolean(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallBooleanMethod(this, _getBoolean5135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Bundle.staticClass, _getBoolean5135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean5136; 
		public bool getBoolean(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallBooleanMethod(this, _getBoolean5136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Bundle.staticClass, _getBoolean5136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putBoolean5137; 
		public void putBoolean(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putBoolean5137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putBoolean5137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByte5138; 
		public byte getByte(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallByteMethod(this, _getByte5138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualByteMethod(this, android.os.Bundle.staticClass, _getByte5138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByte5139; 
		public java.lang.Byte getByte(java.lang.String arg0, byte arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallObjectMethodPtr(this, _getByte5139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getByte5139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putByte5140; 
		public void putByte(java.lang.String arg0, byte arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putByte5140, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putByte5140, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort5141; 
		public short getShort(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallShortMethod(this, _getShort5141, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.os.Bundle.staticClass, _getShort5141, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort5142; 
		public short getShort(java.lang.String arg0, short arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallShortMethod(this, _getShort5142, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.os.Bundle.staticClass, _getShort5142, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putShort5143; 
		public void putShort(java.lang.String arg0, short arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putShort5143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putShort5143, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChar5144; 
		public char getChar(java.lang.String arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallCharMethod(this, _getChar5144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.os.Bundle.staticClass, _getChar5144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChar5145; 
		public char getChar(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallCharMethod(this, _getChar5145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualCharMethod(this, android.os.Bundle.staticClass, _getChar5145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putChar5146; 
		public void putChar(java.lang.String arg0, char arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putChar5146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putChar5146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt5147; 
		public int getInt(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallIntMethod(this, _getInt5147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Bundle.staticClass, _getInt5147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt5148; 
		public int getInt(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallIntMethod(this, _getInt5148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Bundle.staticClass, _getInt5148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putInt5149; 
		public void putInt(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putInt5149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putInt5149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong5150; 
		public long getLong(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallLongMethod(this, _getLong5150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.os.Bundle.staticClass, _getLong5150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong5151; 
		public long getLong(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallLongMethod(this, _getLong5151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.os.Bundle.staticClass, _getLong5151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putLong5152; 
		public void putLong(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putLong5152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putLong5152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat5153; 
		public float getFloat(java.lang.String arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallFloatMethod(this, _getFloat5153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.os.Bundle.staticClass, _getFloat5153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat5154; 
		public float getFloat(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallFloatMethod(this, _getFloat5154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.os.Bundle.staticClass, _getFloat5154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putFloat5155; 
		public void putFloat(java.lang.String arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putFloat5155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putFloat5155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble5156; 
		public double getDouble(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallDoubleMethod(this, _getDouble5156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.os.Bundle.staticClass, _getDouble5156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble5157; 
		public double getDouble(java.lang.String arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallDoubleMethod(this, _getDouble5157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.os.Bundle.staticClass, _getDouble5157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putDouble5158; 
		public void putDouble(java.lang.String arg0, double arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putDouble5158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putDouble5158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear5159; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _clear5159); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _clear5159); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString5160; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5160)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _toString5160)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty5161; 
		public bool isEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallBooleanMethod(this, _isEmpty5161); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Bundle.staticClass, _isEmpty5161); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size5162; 
		public int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallIntMethod(this, _size5162); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Bundle.staticClass, _size5162); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putAll5163; 
		public void putAll(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putAll5163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putAll5163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove5164; 
		public void remove(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _remove5164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _remove5164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keySet5165; 
		public java.util.Set keySet() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, _keySet5165)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _keySet5165)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _containsKey5166; 
		public bool containsKey(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallBooleanMethod(this, _containsKey5166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Bundle.staticClass, _containsKey5166, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBundle5167; 
		public android.os.Bundle getBundle(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getBundle5167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getBundle5167, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString5168; 
		public java.lang.String getString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString5168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getString5168, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5169; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _writeToParcel5169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _writeToParcel5169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5170; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallIntMethod(this, _describeContents5170); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Bundle.staticClass, _describeContents5170); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors5171; 
		public bool hasFileDescriptors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return @__env.CallBooleanMethod(this, _hasFileDescriptors5171); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Bundle.staticClass, _hasFileDescriptors5171); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel5172; 
		public void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _readFromParcel5172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _readFromParcel5172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringArray5173; 
		public java.lang.String[] getStringArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getStringArray5173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getStringArray5173, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntArray5174; 
		public int[] getIntArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getIntArray5174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getIntArray5174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClassLoader5175; 
		public void setClassLoader(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _setClassLoader5175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _setClassLoader5175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putString5176; 
		public void putString(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putString5176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putString5176, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putCharSequence5177; 
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putCharSequence5177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putCharSequence5177, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putParcelable5178; 
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putParcelable5178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putParcelable5178, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArray5179; 
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putParcelableArray5179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putParcelableArray5179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArrayList5180; 
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putParcelableArrayList5180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putParcelableArrayList5180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putSparseParcelableArray5181; 
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putSparseParcelableArray5181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putSparseParcelableArray5181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putIntegerArrayList5182; 
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putIntegerArrayList5182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putIntegerArrayList5182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putStringArrayList5183; 
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putStringArrayList5183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putStringArrayList5183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putSerializable5184; 
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putSerializable5184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putSerializable5184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putBooleanArray5185; 
		public void putBooleanArray(java.lang.String arg0, bool[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putBooleanArray5185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putBooleanArray5185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putByteArray5186; 
		public void putByteArray(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putByteArray5186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putByteArray5186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putShortArray5187; 
		public void putShortArray(java.lang.String arg0, short[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putShortArray5187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putShortArray5187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putCharArray5188; 
		public void putCharArray(java.lang.String arg0, char[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putCharArray5188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putCharArray5188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putIntArray5189; 
		public void putIntArray(java.lang.String arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putIntArray5189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putIntArray5189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putLongArray5190; 
		public void putLongArray(java.lang.String arg0, long[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putLongArray5190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putLongArray5190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putFloatArray5191; 
		public void putFloatArray(java.lang.String arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putFloatArray5191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putFloatArray5191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putDoubleArray5192; 
		public void putDoubleArray(java.lang.String arg0, double[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putDoubleArray5192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putDoubleArray5192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putStringArray5193; 
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putStringArray5193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putStringArray5193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putBundle5194; 
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				@__env.CallVoidMethod(this, _putBundle5194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Bundle.staticClass, _putBundle5194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharSequence5195; 
		public java.lang.CharSequence getCharSequence(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getCharSequence5195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getCharSequence5195, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelable5196; 
		public android.os.Parcelable getParcelable(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _getParcelable5196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getParcelable5196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArray5197; 
		public android.os.Parcelable[] getParcelableArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getParcelableArray5197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getParcelableArray5197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArrayList5198; 
		public java.util.ArrayList getParcelableArrayList(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getParcelableArrayList5198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getParcelableArrayList5198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSparseParcelableArray5199; 
		public android.util.SparseArray getSparseParcelableArray(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallObjectMethodPtr(this, _getSparseParcelableArray5199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getSparseParcelableArray5199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSerializable5200; 
		public java.io.Serializable getSerializable(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, _getSerializable5200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getSerializable5200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerArrayList5201; 
		public java.util.ArrayList getIntegerArrayList(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getIntegerArrayList5201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getIntegerArrayList5201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStringArrayList5202; 
		public java.util.ArrayList getStringArrayList(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Bundle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getStringArrayList5202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getStringArrayList5202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBooleanArray5203; 
		public bool[] getBooleanArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBooleanArray5203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getBooleanArray5203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByteArray5204; 
		public byte[] getByteArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getByteArray5204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getByteArray5204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShortArray5205; 
		public short[] getShortArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getShortArray5205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getShortArray5205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCharArray5206; 
		public char[] getCharArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getCharArray5206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getCharArray5206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongArray5207; 
		public long[] getLongArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getLongArray5207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getLongArray5207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloatArray5208; 
		public float[] getFloatArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getFloatArray5208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getFloatArray5208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleArray5209; 
		public double[] getDoubleArray(java.lang.String arg0) 
		{ 
			if (GetType() == typeof(android.os.Bundle)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getDoubleArray5209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Bundle.staticClass, _getDoubleArray5209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5210; 
		public Bundle()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Bundle.staticClass, _Bundle5210, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5211; 
		public Bundle(java.lang.ClassLoader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Bundle.staticClass, _Bundle5211, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5212; 
		public Bundle(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Bundle.staticClass, _Bundle5212, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5213; 
		public Bundle(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Bundle.staticClass, _Bundle5213, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY5214; 
		public static android.os.Bundle EMPTY
		{ 
			get 
			{ 
				return default(android.os.Bundle); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5215; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Bundle.staticClass = @__class; 
			global::android.os.Bundle._get5133 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.os.Bundle._clone5134 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::android.os.Bundle._getBoolean5135 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z"); 
			global::android.os.Bundle._getBoolean5136 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z"); 
			global::android.os.Bundle._putBoolean5137 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V"); 
			global::android.os.Bundle._getByte5138 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B"); 
			global::android.os.Bundle._getByte5139 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;"); 
			global::android.os.Bundle._putByte5140 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V"); 
			global::android.os.Bundle._getShort5141 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S"); 
			global::android.os.Bundle._getShort5142 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S"); 
			global::android.os.Bundle._putShort5143 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V"); 
			global::android.os.Bundle._getChar5144 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C"); 
			global::android.os.Bundle._getChar5145 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C"); 
			global::android.os.Bundle._putChar5146 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V"); 
			global::android.os.Bundle._getInt5147 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I"); 
			global::android.os.Bundle._getInt5148 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I"); 
			global::android.os.Bundle._putInt5149 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V"); 
			global::android.os.Bundle._getLong5150 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J"); 
			global::android.os.Bundle._getLong5151 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J"); 
			global::android.os.Bundle._putLong5152 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V"); 
			global::android.os.Bundle._getFloat5153 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F"); 
			global::android.os.Bundle._getFloat5154 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F"); 
			global::android.os.Bundle._putFloat5155 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V"); 
			global::android.os.Bundle._getDouble5156 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D"); 
			global::android.os.Bundle._getDouble5157 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D"); 
			global::android.os.Bundle._putDouble5158 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V"); 
			global::android.os.Bundle._clear5159 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "clear", "()V"); 
			global::android.os.Bundle._toString5160 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.Bundle._isEmpty5161 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "isEmpty", "()Z"); 
			global::android.os.Bundle._size5162 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "size", "()I"); 
			global::android.os.Bundle._putAll5163 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V"); 
			global::android.os.Bundle._remove5164 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V"); 
			global::android.os.Bundle._keySet5165 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;"); 
			global::android.os.Bundle._containsKey5166 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z"); 
			global::android.os.Bundle._getBundle5167 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;"); 
			global::android.os.Bundle._getString5168 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.os.Bundle._writeToParcel5169 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.Bundle._describeContents5170 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "describeContents", "()I"); 
			global::android.os.Bundle._hasFileDescriptors5171 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z"); 
			global::android.os.Bundle._readFromParcel5172 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.os.Bundle._getStringArray5173 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;"); 
			global::android.os.Bundle._getIntArray5174 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I"); 
			global::android.os.Bundle._setClassLoader5175 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V"); 
			global::android.os.Bundle._putString5176 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.os.Bundle._putCharSequence5177 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V"); 
			global::android.os.Bundle._putParcelable5178 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V"); 
			global::android.os.Bundle._putParcelableArray5179 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V"); 
			global::android.os.Bundle._putParcelableArrayList5180 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V"); 
			global::android.os.Bundle._putSparseParcelableArray5181 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V"); 
			global::android.os.Bundle._putIntegerArrayList5182 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V"); 
			global::android.os.Bundle._putStringArrayList5183 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V"); 
			global::android.os.Bundle._putSerializable5184 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V"); 
			global::android.os.Bundle._putBooleanArray5185 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V"); 
			global::android.os.Bundle._putByteArray5186 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V"); 
			global::android.os.Bundle._putShortArray5187 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V"); 
			global::android.os.Bundle._putCharArray5188 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V"); 
			global::android.os.Bundle._putIntArray5189 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V"); 
			global::android.os.Bundle._putLongArray5190 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V"); 
			global::android.os.Bundle._putFloatArray5191 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V"); 
			global::android.os.Bundle._putDoubleArray5192 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V"); 
			global::android.os.Bundle._putStringArray5193 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V"); 
			global::android.os.Bundle._putBundle5194 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V"); 
			global::android.os.Bundle._getCharSequence5195 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;"); 
			global::android.os.Bundle._getParcelable5196 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;"); 
			global::android.os.Bundle._getParcelableArray5197 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;"); 
			global::android.os.Bundle._getParcelableArrayList5198 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.os.Bundle._getSparseParcelableArray5199 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;"); 
			global::android.os.Bundle._getSerializable5200 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;"); 
			global::android.os.Bundle._getIntegerArrayList5201 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.os.Bundle._getStringArrayList5202 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.os.Bundle._getBooleanArray5203 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z"); 
			global::android.os.Bundle._getByteArray5204 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B"); 
			global::android.os.Bundle._getShortArray5205 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S"); 
			global::android.os.Bundle._getCharArray5206 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C"); 
			global::android.os.Bundle._getLongArray5207 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J"); 
			global::android.os.Bundle._getFloatArray5208 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F"); 
			global::android.os.Bundle._getDoubleArray5209 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D"); 
			global::android.os.Bundle._Bundle5210 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "()V"); 
			global::android.os.Bundle._Bundle5211 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V"); 
			global::android.os.Bundle._Bundle5212 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(I)V"); 
			global::android.os.Bundle._Bundle5213 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V"); 
		} 
	} 
} 
