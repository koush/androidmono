namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SparseIntArray : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SparseIntArray() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.SparseIntArray), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.SparseIntArray(@__env); 
			} 
		} 
		protected SparseIntArray(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7223; 
		public virtual int get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _get7223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _get7223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get7224; 
		public virtual int get(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _get7224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _get7224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put7225; 
		public virtual void put(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, _put7225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseIntArray.staticClass, _put7225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear7226; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, _clear7226); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseIntArray.staticClass, _clear7226); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _append7227; 
		public virtual void append(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, _append7227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseIntArray.staticClass, _append7227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size7228; 
		public virtual int size() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _size7228); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _size7228); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _delete7229; 
		public virtual void delete(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, _delete7229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseIntArray.staticClass, _delete7229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _keyAt7230; 
		public virtual int keyAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _keyAt7230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _keyAt7230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueAt7231; 
		public virtual int valueAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _valueAt7231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _valueAt7231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfKey7232; 
		public virtual int indexOfKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _indexOfKey7232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _indexOfKey7232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfValue7233; 
		public virtual int indexOfValue(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				return @__env.CallIntMethod(this, _indexOfValue7233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.SparseIntArray.staticClass, _indexOfValue7233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAt7234; 
		public virtual void removeAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.SparseIntArray)) 
				@__env.CallVoidMethod(this, _removeAt7234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.SparseIntArray.staticClass, _removeAt7234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseIntArray7235; 
		public SparseIntArray(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseIntArray.staticClass, _SparseIntArray7235, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SparseIntArray7236; 
		public SparseIntArray()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.SparseIntArray.staticClass, _SparseIntArray7236, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.SparseIntArray.staticClass = @__class; 
			global::android.util.SparseIntArray._get7223 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "get", "(I)I"); 
			global::android.util.SparseIntArray._get7224 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "get", "(II)I"); 
			global::android.util.SparseIntArray._put7225 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "put", "(II)V"); 
			global::android.util.SparseIntArray._clear7226 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "clear", "()V"); 
			global::android.util.SparseIntArray._append7227 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "append", "(II)V"); 
			global::android.util.SparseIntArray._size7228 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "size", "()I"); 
			global::android.util.SparseIntArray._delete7229 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "delete", "(I)V"); 
			global::android.util.SparseIntArray._keyAt7230 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "keyAt", "(I)I"); 
			global::android.util.SparseIntArray._valueAt7231 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "valueAt", "(I)I"); 
			global::android.util.SparseIntArray._indexOfKey7232 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "indexOfKey", "(I)I"); 
			global::android.util.SparseIntArray._indexOfValue7233 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "indexOfValue", "(I)I"); 
			global::android.util.SparseIntArray._removeAt7234 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "removeAt", "(I)V"); 
			global::android.util.SparseIntArray._SparseIntArray7235 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "<init>", "(I)V"); 
			global::android.util.SparseIntArray._SparseIntArray7236 = @__env.GetMethodID(global::android.util.SparseIntArray.staticClass, "<init>", "()V"); 
		} 
	} 
} 
