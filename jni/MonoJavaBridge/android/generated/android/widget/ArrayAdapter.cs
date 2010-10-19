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
		internal static global::MonoJavaBridge.MethodId _add11463;
		public virtual void add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._add11463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._add11463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear11464;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._clear11464);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._clear11464);
		}
		internal static global::MonoJavaBridge.MethodId _remove11465;
		public virtual void remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._remove11465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._remove11465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext11466;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getContext11466)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getContext11466)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _insert11467;
		public virtual void insert(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._insert11467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._insert11467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort11468;
		public virtual void sort(java.util.Comparator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._sort11468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._sort11468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPosition11469;
		public virtual int getPosition(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getPosition11469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getPosition11469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount11470;
		public override int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getCount11470);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getCount11470);
		}
		internal static global::MonoJavaBridge.MethodId _getItem11471;
		public override global::java.lang.Object getItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getItem11471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItem11471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getItemId11472;
		public override long getItemId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getItemId11472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getItemId11472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Filter Filter
		{
			get
			{
				return getFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFilter11473;
		public virtual global::android.widget.Filter getFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getFilter11473)) as android.widget.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getFilter11473)) as android.widget.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _getView11474;
		public override global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getView11474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getView11474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getDropDownView11475;
		public override global::android.view.View getDropDownView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter._getDropDownView11475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._getDropDownView11475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _notifyDataSetChanged11476;
		public override void notifyDataSetChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._notifyDataSetChanged11476);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._notifyDataSetChanged11476);
		}
		internal static global::MonoJavaBridge.MethodId _setNotifyOnChange11477;
		public virtual void setNotifyOnChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._setNotifyOnChange11477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setNotifyOnChange11477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDropDownViewResource11478;
		public virtual void setDropDownViewResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter._setDropDownViewResource11478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._setDropDownViewResource11478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFromResource11479;
		public static global::android.widget.ArrayAdapter createFromResource(android.content.Context arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._createFromResource11479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.ArrayAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter11480;
		public ArrayAdapter(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter11480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter11481;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter11481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter11482;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.lang.Object[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter11482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter11483;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.lang.Object[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter11483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter11484;
		public ArrayAdapter(android.content.Context arg0, int arg1, java.util.List arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter11484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayAdapter11485;
		public ArrayAdapter(android.content.Context arg0, int arg1, int arg2, java.util.List arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ArrayAdapter.staticClass, global::android.widget.ArrayAdapter._ArrayAdapter11485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ArrayAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ArrayAdapter"));
			global::android.widget.ArrayAdapter._add11463 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "add", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._clear11464 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "clear", "()V");
			global::android.widget.ArrayAdapter._remove11465 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "remove", "(Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._getContext11466 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.widget.ArrayAdapter._insert11467 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "insert", "(Ljava/lang/Object;I)V");
			global::android.widget.ArrayAdapter._sort11468 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "sort", "(Ljava/util/Comparator;)V");
			global::android.widget.ArrayAdapter._getPosition11469 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getPosition", "(Ljava/lang/Object;)I");
			global::android.widget.ArrayAdapter._getCount11470 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getCount", "()I");
			global::android.widget.ArrayAdapter._getItem11471 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getItem", "(I)Ljava/lang/Object;");
			global::android.widget.ArrayAdapter._getItemId11472 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getItemId", "(I)J");
			global::android.widget.ArrayAdapter._getFilter11473 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getFilter", "()Landroid/widget/Filter;");
			global::android.widget.ArrayAdapter._getView11474 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._getDropDownView11475 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ArrayAdapter._notifyDataSetChanged11476 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "notifyDataSetChanged", "()V");
			global::android.widget.ArrayAdapter._setNotifyOnChange11477 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "setNotifyOnChange", "(Z)V");
			global::android.widget.ArrayAdapter._setDropDownViewResource11478 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "setDropDownViewResource", "(I)V");
			global::android.widget.ArrayAdapter._createFromResource11479 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;");
			global::android.widget.ArrayAdapter._ArrayAdapter11480 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.widget.ArrayAdapter._ArrayAdapter11481 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II)V");
			global::android.widget.ArrayAdapter._ArrayAdapter11482 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter11483 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter11484 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
			global::android.widget.ArrayAdapter._ArrayAdapter11485 = @__env.GetMethodIDNoThrow(global::android.widget.ArrayAdapter.staticClass, "<init>", "(Landroid/content/Context;IILjava/util/List;)V");
		}
	}
}
