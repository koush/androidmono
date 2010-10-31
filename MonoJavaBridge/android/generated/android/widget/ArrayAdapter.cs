namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArrayAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V", ref global::android.widget.ArrayAdapter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "clear", "()V", ref global::android.widget.ArrayAdapter._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V", ref global::android.widget.ArrayAdapter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.widget.ArrayAdapter._m3) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void insert(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V", ref global::android.widget.ArrayAdapter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void sort(java.util.Comparator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V", ref global::android.widget.ArrayAdapter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getPosition(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I", ref global::android.widget.ArrayAdapter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ArrayAdapter.staticClass, "getCount", "()I", ref global::android.widget.ArrayAdapter._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.Object getItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;", ref global::android.widget.ArrayAdapter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override long getItemId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J", ref global::android.widget.ArrayAdapter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.widget.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;", ref global::android.widget.ArrayAdapter._m10) as android.widget.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ArrayAdapter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.widget.ArrayAdapter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void notifyDataSetChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V", ref global::android.widget.ArrayAdapter._m13);
		}
		public new bool NotifyOnChange
		{
			set
			{
				setNotifyOnChange(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setNotifyOnChange(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V", ref global::android.widget.ArrayAdapter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DropDownViewResource
		{
			set
			{
				setDropDownViewResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setDropDownViewResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V", ref global::android.widget.ArrayAdapter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m16.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m16 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.ArrayAdapter;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public ArrayAdapter(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m17.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m17 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m18.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m18 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m19.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m19 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m20.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m20 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m21.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m21 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ArrayAdapter._m22.native == global::System.IntPtr.Zero)
				global::android.widget.ArrayAdapter._m22 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static ArrayAdapter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ArrayAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ArrayAdapter"));
		}
	}
}
