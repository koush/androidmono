namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SparseBooleanArray : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SparseBooleanArray() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.SparseBooleanArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.SparseBooleanArray(@__env); 
			} 
		} 
		protected SparseBooleanArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7210; 
		public virtual bool get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallBooleanMethod(this, _get7210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.util.SparseBooleanArray.staticClass, _get7210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7211; 
		public virtual bool get(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallBooleanMethod(this, _get7211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.util.SparseBooleanArray.staticClass, _get7211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put7212; 
		public virtual void put(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				@__env.CallVoidMethod(this, _put7212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseBooleanArray.staticClass, _put7212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7213; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				@__env.CallVoidMethod(this, _clear7213); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseBooleanArray.staticClass, _clear7213); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append7214; 
		public virtual void append(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				@__env.CallVoidMethod(this, _append7214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseBooleanArray.staticClass, _append7214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7215; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallIntMethod(this, _size7215); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseBooleanArray.staticClass, _size7215); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete7216; 
		public virtual void delete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				@__env.CallVoidMethod(this, _delete7216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseBooleanArray.staticClass, _delete7216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyAt7217; 
		public virtual int keyAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallIntMethod(this, _keyAt7217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseBooleanArray.staticClass, _keyAt7217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueAt7218; 
		public virtual bool valueAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallBooleanMethod(this, _valueAt7218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.util.SparseBooleanArray.staticClass, _valueAt7218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey7219; 
		public virtual int indexOfKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallIntMethod(this, _indexOfKey7219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseBooleanArray.staticClass, _indexOfKey7219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue7220; 
		public virtual int indexOfValue(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseBooleanArray)) 
				return @__env.CallIntMethod(this, _indexOfValue7220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseBooleanArray.staticClass, _indexOfValue7220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseBooleanArray7221; 
		public SparseBooleanArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseBooleanArray.staticClass, _SparseBooleanArray7221, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseBooleanArray7222; 
		public SparseBooleanArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseBooleanArray.staticClass, _SparseBooleanArray7222, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.SparseBooleanArray.staticClass = @__class; 
			global::android.util.SparseBooleanArray._get7210 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "get", "(I)Z"); 
			global::android.util.SparseBooleanArray._get7211 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "get", "(IZ)Z"); 
			global::android.util.SparseBooleanArray._put7212 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "put", "(IZ)V"); 
			global::android.util.SparseBooleanArray._clear7213 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "clear", "()V"); 
			global::android.util.SparseBooleanArray._append7214 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "append", "(IZ)V"); 
			global::android.util.SparseBooleanArray._size7215 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "size", "()I"); 
			global::android.util.SparseBooleanArray._delete7216 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "delete", "(I)V"); 
			global::android.util.SparseBooleanArray._keyAt7217 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "keyAt", "(I)I"); 
			global::android.util.SparseBooleanArray._valueAt7218 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "valueAt", "(I)Z"); 
			global::android.util.SparseBooleanArray._indexOfKey7219 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "indexOfKey", "(I)I"); 
			global::android.util.SparseBooleanArray._indexOfValue7220 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "indexOfValue", "(Z)I"); 
			global::android.util.SparseBooleanArray._SparseBooleanArray7221 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "<init>", "(I)V"); 
			global::android.util.SparseBooleanArray._SparseBooleanArray7222 = @__env.GetMethodID(global::android.util.SparseBooleanArray.staticClass, "<init>", "()V"); 
		} 
	} 
} 
