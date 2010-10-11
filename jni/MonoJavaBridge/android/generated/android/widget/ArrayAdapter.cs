namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayAdapter : android.widget.BaseAdapter, Filterable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrayAdapter()
		{
			InitJNI();
		}
		protected ArrayAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add10917;
		public virtual void add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._add10917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._add10917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear10918;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._clear10918);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._clear10918);
		}
		internal static global::MonoJavaBridge.MethodId _remove10919;
		public virtual void remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._remove10919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._remove10919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContext10920;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getContext10920)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getContext10920)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _insert10921;
		public virtual void insert(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._insert10921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._insert10921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort10922;
		public virtual void sort(java.util.Comparator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._sort10922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._sort10922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPosition10923;
		public virtual int getPosition(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getPosition10923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getPosition10923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount10924;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getCount10924);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getCount10924);
		}
		internal static global::MonoJavaBridge.MethodId _getItem10925;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getItem10925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItem10925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId10926;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getItemId10926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItemId10926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFilter10927;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getFilter10927)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getFilter10927)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _getView10928;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getView10928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getView10928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView10929;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getDropDownView10929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getDropDownView10929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged10930;
		public override void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._notifyDataSetChanged10930);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._notifyDataSetChanged10930);
		}
		internal static global::MonoJavaBridge.MethodId _setNotifyOnChange10931;
		public virtual void setNotifyOnChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._setNotifyOnChange10931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setNotifyOnChange10931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource10932;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._setDropDownViewResource10932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setDropDownViewResource10932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFromResource10933;
		public static global::android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._createFromResource10933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.ArrayAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter10934;
		public ArrayAdapter(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter10935;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter10936;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter10937;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter10938;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter10939;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter10939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ArrayAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ArrayAdapter"));
			global::android.widget.ArrayAdapter._add10917 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._clear10918 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "clear", "()V");
			global::android.widget.ArrayAdapter._remove10919 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._getContext10920 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.widget.ArrayAdapter._insert10921 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V");
			global::android.widget.ArrayAdapter._sort10922 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V");
			global::android.widget.ArrayAdapter._getPosition10923 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I");
			global::android.widget.ArrayAdapter._getCount10924 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getCount", "()I");
			global::android.widget.ArrayAdapter._getItem10925 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ArrayAdapter._getItemId10926 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.ArrayAdapter._getFilter10927 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.ArrayAdapter._getView10928 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._getDropDownView10929 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._notifyDataSetChanged10930 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.ArrayAdapter._setNotifyOnChange10931 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V");
			global::android.widget.ArrayAdapter._setDropDownViewResource10932 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.ArrayAdapter._createFromResource10933 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;");
			global::android.widget.ArrayAdapter._ArrayAdapter10934 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10935 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10936 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10937 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10938 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter10939 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V");
		}
	}
}
