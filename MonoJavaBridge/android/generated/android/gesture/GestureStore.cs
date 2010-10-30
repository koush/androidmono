namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load4966;
		public virtual void load(java.io.InputStream arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;Z)V", ref global::android.gesture.GestureStore._load4966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load4967;
		public virtual void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;)V", ref global::android.gesture.GestureStore._load4967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _save4968;
		public virtual void save(java.io.OutputStream arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;Z)V", ref global::android.gesture.GestureStore._save4968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _save4969;
		public virtual void save(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;)V", ref global::android.gesture.GestureStore._save4969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged4970;
		public virtual bool hasChanged()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureStore.staticClass, "hasChanged", "()Z", ref global::android.gesture.GestureStore._hasChanged4970);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientationStyle4971;
		public virtual void setOrientationStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "setOrientationStyle", "(I)V", ref global::android.gesture.GestureStore._setOrientationStyle4971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrientationStyle4972;
		public virtual int getOrientationStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureStore.staticClass, "getOrientationStyle", "()I", ref global::android.gesture.GestureStore._getOrientationStyle4972);
		}
		internal static global::MonoJavaBridge.MethodId _setSequenceType4973;
		public virtual void setSequenceType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "setSequenceType", "(I)V", ref global::android.gesture.GestureStore._setSequenceType4973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSequenceType4974;
		public virtual int getSequenceType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureStore.staticClass, "getSequenceType", "()I", ref global::android.gesture.GestureStore._getSequenceType4974);
		}
		public new global::java.util.Set GestureEntries
		{
			get
			{
				return getGestureEntries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGestureEntries4975;
		public virtual global::java.util.Set getGestureEntries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.gesture.GestureStore.staticClass, "getGestureEntries", "()Ljava/util/Set;", ref global::android.gesture.GestureStore._getGestureEntries4975) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _recognize4976;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStore.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;", ref global::android.gesture.GestureStore._recognize4976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _addGesture4977;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureStore._addGesture4977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeGesture4978;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureStore._removeGesture4978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeEntry4979;
		public virtual void removeEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "removeEntry", "(Ljava/lang/String;)V", ref global::android.gesture.GestureStore._removeEntry4979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGestures4980;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStore.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.gesture.GestureStore._getGestures4980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _GestureStore4981;
		public GestureStore() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureStore._GestureStore4981.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureStore._GestureStore4981 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._GestureStore4981);
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
		static GestureStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureStore"));
		}
		internal static void InitJNI()
		{
		}
	}
}
