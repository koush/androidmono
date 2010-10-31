namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void load(java.io.InputStream arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;Z)V", ref global::android.gesture.GestureStore._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "load", "(Ljava/io/InputStream;)V", ref global::android.gesture.GestureStore._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void save(java.io.OutputStream arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;Z)V", ref global::android.gesture.GestureStore._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void save(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "save", "(Ljava/io/OutputStream;)V", ref global::android.gesture.GestureStore._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool hasChanged()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureStore.staticClass, "hasChanged", "()Z", ref global::android.gesture.GestureStore._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setOrientationStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "setOrientationStyle", "(I)V", ref global::android.gesture.GestureStore._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getOrientationStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureStore.staticClass, "getOrientationStyle", "()I", ref global::android.gesture.GestureStore._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setSequenceType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "setSequenceType", "(I)V", ref global::android.gesture.GestureStore._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getSequenceType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureStore.staticClass, "getSequenceType", "()I", ref global::android.gesture.GestureStore._m8);
		}
		public new global::java.util.Set GestureEntries
		{
			get
			{
				return getGestureEntries();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.util.Set getGestureEntries()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.gesture.GestureStore.staticClass, "getGestureEntries", "()Ljava/util/Set;", ref global::android.gesture.GestureStore._m9) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.ArrayList recognize(android.gesture.Gesture arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStore.staticClass, "recognize", "(Landroid/gesture/Gesture;)Ljava/util/ArrayList;", ref global::android.gesture.GestureStore._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "addGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureStore._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void removeGesture(java.lang.String arg0, android.gesture.Gesture arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "removeGesture", "(Ljava/lang/String;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureStore._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void removeEntry(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureStore.staticClass, "removeEntry", "(Ljava/lang/String;)V", ref global::android.gesture.GestureStore._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.util.ArrayList getGestures(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureStore.staticClass, "getGestures", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.gesture.GestureStore._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public GestureStore() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureStore._m15.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureStore._m15 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureStore.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureStore.staticClass, global::android.gesture.GestureStore._m15);
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
	}
}
