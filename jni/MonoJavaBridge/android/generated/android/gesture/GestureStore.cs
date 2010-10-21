namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureStore()
		{
			InitJNI();
		}
		protected GestureStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load4947;
		public virtual void load(java.io.InputStream arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._load4947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._load4947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load4948;
		public virtual void load(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._load4948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._load4948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save4949;
		public virtual void save(java.io.OutputStream arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._save4949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._save4949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _save4950;
		public virtual void save(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._save4950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._save4950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged4951;
		public virtual bool hasChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureStore._hasChanged4951);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._hasChanged4951);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientationStyle4952;
		public virtual void setOrientationStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._setOrientationStyle4952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._setOrientationStyle4952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int OrientationStyle
		{
			get
			{
				return getOrientationStyle();
			}
			set
			{
				setOrientationStyle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOrientationStyle4953;
		public virtual int getOrientationStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureStore._getOrientationStyle4953);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getOrientationStyle4953);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceType4954;
		public virtual void setSequenceType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._setSequenceType4954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._setSequenceType4954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SequenceType
		{
			get
			{
				return getSequenceType();
			}
			set
			{
				setSequenceType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSequenceType4955;
		public virtual int getSequenceType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureStore._getSequenceType4955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getSequenceType4955);
		}
		public new global::java.util.Set GestureEntries
		{
			get
			{
				return getGestureEntries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGestureEntries4956;
		public virtual global::java.util.Set getGestureEntries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStore._getGestureEntries4956)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getGestureEntries4956)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _recognize4957;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStore._recognize4957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._recognize4957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addGesture4958;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._addGesture4958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._addGesture4958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeGesture4959;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._removeGesture4959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._removeGesture4959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry4960;
		public virtual void removeEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureStore._removeEntry4960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._removeEntry4960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestures4961;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureStore._getGestures4961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._getGestures4961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _GestureStore4962;
		public GestureStore()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._GestureStore4962);
			Init(@__env, handle);
		}
		public static int SEQUENCE_INVARIANT
		{
			get
			{
				return 1;
			}
		}
		public static int SEQUENCE_SENSITIVE
		{
			get
			{
				return 2;
			}
		}
		public static int ORIENTATION_INVARIANT
		{
			get
			{
				return 1;
			}
		}
		public static int ORIENTATION_SENSITIVE
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureStore"));
			global::android.gesture.GestureStore._load4947 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;Z)V");
			global::android.gesture.GestureStore._load4948 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::android.gesture.GestureStore._save4949 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;Z)V");
			global::android.gesture.GestureStore._save4950 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;)V");
			global::android.gesture.GestureStore._hasChanged4951 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "hasChanged", "()Z");
			global::android.gesture.GestureStore._setOrientationStyle4952 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "setOrientationStyle", "(I)V");
			global::android.gesture.GestureStore._getOrientationStyle4953 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getOrientationStyle", "()I");
			global::android.gesture.GestureStore._setSequenceType4954 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "setSequenceType", "(I)V");
			global::android.gesture.GestureStore._getSequenceType4955 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getSequenceType", "()I");
			global::android.gesture.GestureStore._getGestureEntries4956 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getGestureEntries", "()Ljava/util/Set;");
			global::android.gesture.GestureStore._recognize4957 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;");
			global::android.gesture.GestureStore._addGesture4958 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureStore._removeGesture4959 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureStore._removeEntry4960 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "removeEntry", "(Ljava/lang/String;)V");
			global::android.gesture.GestureStore._getGestures4961 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.gesture.GestureStore._GestureStore4962 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "<init>", "()V");
		}
	}
}
