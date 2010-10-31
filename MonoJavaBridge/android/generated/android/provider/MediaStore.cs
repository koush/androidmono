namespace android.provider
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MediaStore : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MediaStore(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Audio : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Audio(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.AlbumColumns_))]
			public partial interface AlbumColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.AlbumColumns))]
			internal sealed partial class AlbumColumns_ : java.lang.Object, AlbumColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal AlbumColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static AlbumColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.AlbumColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$AlbumColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class AlbumColumnsConstants 
			{
				public static global::java.lang.String ALBUM_ID
				{
					get
					{
						return "album_id";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String NUMBER_OF_SONGS
				{
					get
					{
						return "numsongs";
					}
				}
				public static global::java.lang.String NUMBER_OF_SONGS_FOR_ARTIST
				{
					get
					{
						return "numsongs_by_artist";
					}
				}
				public static global::java.lang.String FIRST_YEAR
				{
					get
					{
						return "minyear";
					}
				}
				public static global::java.lang.String LAST_YEAR
				{
					get
					{
						return "maxyear";
					}
				}
				public static global::java.lang.String ALBUM_KEY
				{
					get
					{
						return "album_key";
					}
				}
				public static global::java.lang.String ALBUM_ART
				{
					get
					{
						return "album_art";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Albums : java.lang.Object, BaseColumns, AlbumColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Albums(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Albums._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Albums._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Albums.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Albums.staticClass, global::android.provider.MediaStore.Audio.Albums._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public Albums() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Albums._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Albums._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Albums.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Albums.staticClass, global::android.provider.MediaStore.Audio.Albums._m1);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4636;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Albums.staticClass, _INTERNAL_CONTENT_URI4636)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4637;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Albums.staticClass, _EXTERNAL_CONTENT_URI4637)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/albums";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/album";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "album_key";
					}
				}
				static Albums()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Albums.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Albums"));
					global::android.provider.MediaStore.Audio.Albums._INTERNAL_CONTENT_URI4636 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Albums.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Albums._EXTERNAL_CONTENT_URI4637 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Albums.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.ArtistColumns_))]
			public partial interface ArtistColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.ArtistColumns))]
			internal sealed partial class ArtistColumns_ : java.lang.Object, ArtistColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal ArtistColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static ArtistColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.ArtistColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$ArtistColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class ArtistColumnsConstants 
			{
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ARTIST_KEY
				{
					get
					{
						return "artist_key";
					}
				}
				public static global::java.lang.String NUMBER_OF_ALBUMS
				{
					get
					{
						return "number_of_albums";
					}
				}
				public static global::java.lang.String NUMBER_OF_TRACKS
				{
					get
					{
						return "number_of_tracks";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Artists : java.lang.Object, BaseColumns, ArtistColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Artists(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				[global::MonoJavaBridge.JavaClass()]
				public sealed partial class Albums : java.lang.Object, AlbumColumns
				{
					internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
					internal Albums(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
					{
					}
					private static global::MonoJavaBridge.MethodId _m0;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Artists.Albums._m0.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Artists.Albums._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Artists.Albums.staticClass, global::android.provider.MediaStore.Audio.Artists.Albums._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
					}
					private static global::MonoJavaBridge.MethodId _m1;
					public Albums() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Artists.Albums._m1.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Artists.Albums._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.Albums.staticClass, "<init>", "()V");
						global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Artists.Albums.staticClass, global::android.provider.MediaStore.Audio.Artists.Albums._m1);
						Init(@__env, handle);
					}
					static Albums()
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::android.provider.MediaStore.Audio.Artists.Albums.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Artists$Albums"));
					}
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Artists._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Artists._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Artists.staticClass, global::android.provider.MediaStore.Audio.Artists._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public Artists() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Artists._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Artists._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Artists.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Artists.staticClass, global::android.provider.MediaStore.Audio.Artists._m1);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4645;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Artists.staticClass, _INTERNAL_CONTENT_URI4645)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4646;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Artists.staticClass, _EXTERNAL_CONTENT_URI4646)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/artists";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/artist";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "artist_key";
					}
				}
				static Artists()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Artists.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Artists"));
					global::android.provider.MediaStore.Audio.Artists._INTERNAL_CONTENT_URI4645 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Artists.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Artists._EXTERNAL_CONTENT_URI4646 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Artists.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.AudioColumns_))]
			public partial interface AudioColumns : MediaColumns
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.AudioColumns))]
			internal sealed partial class AudioColumns_ : java.lang.Object, AudioColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal AudioColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static AudioColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.AudioColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$AudioColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class AudioColumnsConstants 
			{
				public static global::java.lang.String TITLE_KEY
				{
					get
					{
						return "title_key";
					}
				}
				public static global::java.lang.String DURATION
				{
					get
					{
						return "duration";
					}
				}
				public static global::java.lang.String BOOKMARK
				{
					get
					{
						return "bookmark";
					}
				}
				public static global::java.lang.String ARTIST_ID
				{
					get
					{
						return "artist_id";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ARTIST_KEY
				{
					get
					{
						return "artist_key";
					}
				}
				public static global::java.lang.String COMPOSER
				{
					get
					{
						return "composer";
					}
				}
				public static global::java.lang.String ALBUM_ID
				{
					get
					{
						return "album_id";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String ALBUM_KEY
				{
					get
					{
						return "album_key";
					}
				}
				public static global::java.lang.String ALBUM_ART
				{
					get
					{
						return "album_art";
					}
				}
				public static global::java.lang.String TRACK
				{
					get
					{
						return "track";
					}
				}
				public static global::java.lang.String YEAR
				{
					get
					{
						return "year";
					}
				}
				public static global::java.lang.String IS_MUSIC
				{
					get
					{
						return "is_music";
					}
				}
				public static global::java.lang.String IS_PODCAST
				{
					get
					{
						return "is_podcast";
					}
				}
				public static global::java.lang.String IS_RINGTONE
				{
					get
					{
						return "is_ringtone";
					}
				}
				public static global::java.lang.String IS_ALARM
				{
					get
					{
						return "is_alarm";
					}
				}
				public static global::java.lang.String IS_NOTIFICATION
				{
					get
					{
						return "is_notification";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Genres : java.lang.Object, BaseColumns, GenresColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Genres(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				[global::MonoJavaBridge.JavaClass()]
				public sealed partial class Members : java.lang.Object, AudioColumns
				{
					internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
					internal Members(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
					{
					}
					private static global::MonoJavaBridge.MethodId _m0;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Genres.Members._m0.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Genres.Members._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Genres.Members.staticClass, global::android.provider.MediaStore.Audio.Genres.Members._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
					}
					private static global::MonoJavaBridge.MethodId _m1;
					public Members() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Genres.Members._m1.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Genres.Members._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.Members.staticClass, "<init>", "()V");
						global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Genres.Members.staticClass, global::android.provider.MediaStore.Audio.Genres.Members._m1);
						Init(@__env, handle);
					}
					public static global::java.lang.String CONTENT_DIRECTORY
					{
						get
						{
							return "members";
						}
					}
					public static global::java.lang.String DEFAULT_SORT_ORDER
					{
						get
						{
							return "title_key";
						}
					}
					public static global::java.lang.String AUDIO_ID
					{
						get
						{
							return "audio_id";
						}
					}
					public static global::java.lang.String GENRE_ID
					{
						get
						{
							return "genre_id";
						}
					}
					static Members()
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::android.provider.MediaStore.Audio.Genres.Members.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Genres$Members"));
					}
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Genres._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Genres._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Genres.staticClass, global::android.provider.MediaStore.Audio.Genres._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public Genres() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Genres._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Genres._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Genres.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Genres.staticClass, global::android.provider.MediaStore.Audio.Genres._m1);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4672;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Genres.staticClass, _INTERNAL_CONTENT_URI4672)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4673;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Genres.staticClass, _EXTERNAL_CONTENT_URI4673)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/genre";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/genre";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name";
					}
				}
				static Genres()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Genres.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Genres"));
					global::android.provider.MediaStore.Audio.Genres._INTERNAL_CONTENT_URI4672 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Genres.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Genres._EXTERNAL_CONTENT_URI4673 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Genres.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.GenresColumns_))]
			public partial interface GenresColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.GenresColumns))]
			internal sealed partial class GenresColumns_ : java.lang.Object, GenresColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal GenresColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static GenresColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.GenresColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$GenresColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class GenresColumnsConstants 
			{
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Media : java.lang.Object, AudioColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Media(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Media._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Media._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public static global::android.net.Uri getContentUriForPath(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Media._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Media._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "getContentUriForPath", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m2;
				public Media() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Media._m2.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Media._m2 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Media.staticClass, global::android.provider.MediaStore.Audio.Media._m2);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4678;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Media.staticClass, _INTERNAL_CONTENT_URI4678)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4679;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Media.staticClass, _EXTERNAL_CONTENT_URI4679)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/audio";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "title_key";
					}
				}
				public static global::java.lang.String RECORD_SOUND_ACTION
				{
					get
					{
						return "android.provider.MediaStore.RECORD_SOUND";
					}
				}
				public static global::java.lang.String EXTRA_MAX_BYTES
				{
					get
					{
						return "android.provider.MediaStore.extra.MAX_BYTES";
					}
				}
				static Media()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Media.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Media"));
					global::android.provider.MediaStore.Audio.Media._INTERNAL_CONTENT_URI4678 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Media._EXTERNAL_CONTENT_URI4679 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Media.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Playlists : java.lang.Object, BaseColumns, PlaylistsColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Playlists(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				[global::MonoJavaBridge.JavaClass()]
				public sealed partial class Members : java.lang.Object, AudioColumns
				{
					internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
					internal Members(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
					{
					}
					private static global::MonoJavaBridge.MethodId _m0;
					public static global::android.net.Uri getContentUri(java.lang.String arg0, long arg1)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Playlists.Members._m0.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Playlists.Members._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "getContentUri", "(Ljava/lang/String;J)Landroid/net/Uri;");
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
					}
					private static global::MonoJavaBridge.MethodId _m1;
					public static bool moveItem(android.content.ContentResolver arg0, long arg1, int arg2, int arg3)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Playlists.Members._m1.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Playlists.Members._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "moveItem", "(Landroid/content/ContentResolver;JII)Z");
						return @__env.CallStaticBooleanMethod(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
					}
					private static global::MonoJavaBridge.MethodId _m2;
					public Members() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						if (global::android.provider.MediaStore.Audio.Playlists.Members._m2.native == global::System.IntPtr.Zero)
							global::android.provider.MediaStore.Audio.Playlists.Members._m2 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.Members.staticClass, "<init>", "()V");
						global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Playlists.Members.staticClass, global::android.provider.MediaStore.Audio.Playlists.Members._m2);
						Init(@__env, handle);
					}
					public static global::java.lang.String _ID
					{
						get
						{
							return "_id";
						}
					}
					public static global::java.lang.String CONTENT_DIRECTORY
					{
						get
						{
							return "members";
						}
					}
					public static global::java.lang.String AUDIO_ID
					{
						get
						{
							return "audio_id";
						}
					}
					public static global::java.lang.String PLAYLIST_ID
					{
						get
						{
							return "playlist_id";
						}
					}
					public static global::java.lang.String PLAY_ORDER
					{
						get
						{
							return "play_order";
						}
					}
					public static global::java.lang.String DEFAULT_SORT_ORDER
					{
						get
						{
							return "play_order";
						}
					}
					static Members()
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						global::android.provider.MediaStore.Audio.Playlists.Members.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Playlists$Members"));
					}
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Playlists._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Playlists._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.Playlists.staticClass, global::android.provider.MediaStore.Audio.Playlists._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public Playlists() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Audio.Playlists._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Audio.Playlists._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.Playlists.staticClass, global::android.provider.MediaStore.Audio.Playlists._m1);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4690;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Playlists.staticClass, _INTERNAL_CONTENT_URI4690)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4691;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Audio.Playlists.staticClass, _EXTERNAL_CONTENT_URI4691)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/playlist";
					}
				}
				public static global::java.lang.String ENTRY_CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.item/playlist";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "name";
					}
				}
				static Playlists()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.Playlists.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$Playlists"));
					global::android.provider.MediaStore.Audio.Playlists._INTERNAL_CONTENT_URI4690 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Audio.Playlists._EXTERNAL_CONTENT_URI4691 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Audio.Playlists.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Audio.PlaylistsColumns_))]
			public partial interface PlaylistsColumns  : global::MonoJavaBridge.IJavaObject 
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Audio.PlaylistsColumns))]
			internal sealed partial class PlaylistsColumns_ : java.lang.Object, PlaylistsColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal PlaylistsColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static PlaylistsColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Audio.PlaylistsColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio$PlaylistsColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class PlaylistsColumnsConstants 
			{
				public static global::java.lang.String NAME
				{
					get
					{
						return "name";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String DATE_ADDED
				{
					get
					{
						return "date_added";
					}
				}
				public static global::java.lang.String DATE_MODIFIED
				{
					get
					{
						return "date_modified";
					}
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.String keyFor(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.MediaStore.Audio._m0.native == global::System.IntPtr.Zero)
					global::android.provider.MediaStore.Audio._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Audio.staticClass, "keyFor", "(Ljava/lang/String;)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Audio.staticClass, global::android.provider.MediaStore.Audio._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public Audio() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.MediaStore.Audio._m1.native == global::System.IntPtr.Zero)
					global::android.provider.MediaStore.Audio._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Audio.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Audio.staticClass, global::android.provider.MediaStore.Audio._m1);
				Init(@__env, handle);
			}
			static Audio()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.Audio.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Audio"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Images : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Images(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Images.ImageColumns_))]
			public partial interface ImageColumns : MediaColumns
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Images.ImageColumns))]
			internal sealed partial class ImageColumns_ : java.lang.Object, ImageColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal ImageColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static ImageColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Images.ImageColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images$ImageColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class ImageColumnsConstants 
			{
				public static global::java.lang.String DESCRIPTION
				{
					get
					{
						return "description";
					}
				}
				public static global::java.lang.String PICASA_ID
				{
					get
					{
						return "picasa_id";
					}
				}
				public static global::java.lang.String IS_PRIVATE
				{
					get
					{
						return "isprivate";
					}
				}
				public static global::java.lang.String LATITUDE
				{
					get
					{
						return "latitude";
					}
				}
				public static global::java.lang.String LONGITUDE
				{
					get
					{
						return "longitude";
					}
				}
				public static global::java.lang.String DATE_TAKEN
				{
					get
					{
						return "datetaken";
					}
				}
				public static global::java.lang.String ORIENTATION
				{
					get
					{
						return "orientation";
					}
				}
				public static global::java.lang.String MINI_THUMB_MAGIC
				{
					get
					{
						return "mini_thumb_magic";
					}
				}
				public static global::java.lang.String BUCKET_ID
				{
					get
					{
						return "bucket_id";
					}
				}
				public static global::java.lang.String BUCKET_DISPLAY_NAME
				{
					get
					{
						return "bucket_display_name";
					}
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Media : java.lang.Object, ImageColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Media(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.Cursor;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
				}
				private static global::MonoJavaBridge.MethodId _m2;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m2.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.database.Cursor;
				}
				private static global::MonoJavaBridge.MethodId _m3;
				public static global::android.graphics.Bitmap getBitmap(android.content.ContentResolver arg0, android.net.Uri arg1)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m3.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "getBitmap", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Landroid/graphics/Bitmap;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
				}
				private static global::MonoJavaBridge.MethodId _m4;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m4.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m5;
				public static global::java.lang.String insertImage(android.content.ContentResolver arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m5.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
				}
				private static global::MonoJavaBridge.MethodId _m6;
				public static global::java.lang.String insertImage(android.content.ContentResolver arg0, android.graphics.Bitmap arg1, java.lang.String arg2, java.lang.String arg3)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m6.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "insertImage", "(Landroid/content/ContentResolver;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
				}
				private static global::MonoJavaBridge.MethodId _m7;
				public Media() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Media._m7.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Media._m7 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Images.Media.staticClass, global::android.provider.MediaStore.Images.Media._m7);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4709;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Images.Media.staticClass, _INTERNAL_CONTENT_URI4709)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4710;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Images.Media.staticClass, _EXTERNAL_CONTENT_URI4710)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/image";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "bucket_display_name";
					}
				}
				static Media()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Images.Media.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images$Media"));
					global::android.provider.MediaStore.Images.Media._INTERNAL_CONTENT_URI4709 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Images.Media._EXTERNAL_CONTENT_URI4710 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Images.Media.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public partial class Thumbnails : java.lang.Object, BaseColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				protected Thumbnails(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.Cursor;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, long arg2, int arg3, android.graphics.BitmapFactory.Options arg4)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
				}
				private static global::MonoJavaBridge.MethodId _m2;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m2.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
				}
				private static global::MonoJavaBridge.MethodId _m3;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m3.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m4;
				public static global::android.database.Cursor queryMiniThumbnails(android.content.ContentResolver arg0, android.net.Uri arg1, int arg2, java.lang.String[] arg3)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m4.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnails", "(Landroid/content/ContentResolver;Landroid/net/Uri;I[Ljava/lang/String;)Landroid/database/Cursor;");
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
				}
				private static global::MonoJavaBridge.MethodId _m5;
				public static global::android.database.Cursor queryMiniThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, java.lang.String[] arg3)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m5.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m5 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "queryMiniThumbnail", "(Landroid/content/ContentResolver;JI[Ljava/lang/String;)Landroid/database/Cursor;");
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
				}
				private static global::MonoJavaBridge.MethodId _m6;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1, long arg2)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m6.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m6 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V");
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				}
				private static global::MonoJavaBridge.MethodId _m7;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m7.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m7 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V");
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				}
				private static global::MonoJavaBridge.MethodId _m8;
				public Thumbnails() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Images.Thumbnails._m8.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Images.Thumbnails._m8 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Images.Thumbnails.staticClass, global::android.provider.MediaStore.Images.Thumbnails._m8);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4713;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Images.Thumbnails.staticClass, _INTERNAL_CONTENT_URI4713)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4714;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Images.Thumbnails.staticClass, _EXTERNAL_CONTENT_URI4714)) as android.net.Uri;
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "image_id ASC";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String IMAGE_ID
				{
					get
					{
						return "image_id";
					}
				}
				public static global::java.lang.String KIND
				{
					get
					{
						return "kind";
					}
				}
				public static int MINI_KIND
				{
					get
					{
						return 1;
					}
				}
				public static int FULL_SCREEN_KIND
				{
					get
					{
						return 2;
					}
				}
				public static int MICRO_KIND
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String THUMB_DATA
				{
					get
					{
						return "thumb_data";
					}
				}
				public static global::java.lang.String WIDTH
				{
					get
					{
						return "width";
					}
				}
				public static global::java.lang.String HEIGHT
				{
					get
					{
						return "height";
					}
				}
				static Thumbnails()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Images.Thumbnails.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images$Thumbnails"));
					global::android.provider.MediaStore.Images.Thumbnails._INTERNAL_CONTENT_URI4713 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Images.Thumbnails._EXTERNAL_CONTENT_URI4714 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Images.Thumbnails.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public Images() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.MediaStore.Images._m0.native == global::System.IntPtr.Zero)
					global::android.provider.MediaStore.Images._m0 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Images.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Images.staticClass, global::android.provider.MediaStore.Images._m0);
				Init(@__env, handle);
			}
			static Images()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.Images.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Images"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.MediaColumns_))]
		public partial interface MediaColumns : BaseColumns
		{
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.MediaColumns))]
		internal sealed partial class MediaColumns_ : java.lang.Object, MediaColumns
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal MediaColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static MediaColumns_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.MediaColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$MediaColumns"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public static partial class MediaColumnsConstants 
		{
			public static global::java.lang.String DATA
			{
				get
				{
					return "_data";
				}
			}
			public static global::java.lang.String SIZE
			{
				get
				{
					return "_size";
				}
			}
			public static global::java.lang.String DISPLAY_NAME
			{
				get
				{
					return "_display_name";
				}
			}
			public static global::java.lang.String TITLE
			{
				get
				{
					return "title";
				}
			}
			public static global::java.lang.String DATE_ADDED
			{
				get
				{
					return "date_added";
				}
			}
			public static global::java.lang.String DATE_MODIFIED
			{
				get
				{
					return "date_modified";
				}
			}
			public static global::java.lang.String MIME_TYPE
			{
				get
				{
					return "mime_type";
				}
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Video : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Video(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public sealed partial class Media : java.lang.Object, VideoColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal Media(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Media._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Media._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Media.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Media.staticClass, global::android.provider.MediaStore.Video.Media._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public Media() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Media._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Media._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Video.Media.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Video.Media.staticClass, global::android.provider.MediaStore.Video.Media._m1);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4732;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Video.Media.staticClass, _INTERNAL_CONTENT_URI4732)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4733;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Video.Media.staticClass, _EXTERNAL_CONTENT_URI4733)) as android.net.Uri;
					}
				}
				public static global::java.lang.String CONTENT_TYPE
				{
					get
					{
						return "vnd.android.cursor.dir/video";
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "title";
					}
				}
				static Media()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Video.Media.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video$Media"));
					global::android.provider.MediaStore.Video.Media._INTERNAL_CONTENT_URI4732 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Video.Media.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Video.Media._EXTERNAL_CONTENT_URI4733 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Video.Media.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public partial class Thumbnails : java.lang.Object, BaseColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				protected Thumbnails(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				private static global::MonoJavaBridge.MethodId _m0;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, int arg2, android.graphics.BitmapFactory.Options arg3)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Thumbnails._m0.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Thumbnails._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
				}
				private static global::MonoJavaBridge.MethodId _m1;
				public static global::android.graphics.Bitmap getThumbnail(android.content.ContentResolver arg0, long arg1, long arg2, int arg3, android.graphics.BitmapFactory.Options arg4)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Thumbnails._m1.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Thumbnails._m1 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getThumbnail", "(Landroid/content/ContentResolver;JJILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
				}
				private static global::MonoJavaBridge.MethodId _m2;
				public static global::android.net.Uri getContentUri(java.lang.String arg0)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Thumbnails._m2.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Thumbnails._m2 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "getContentUri", "(Ljava/lang/String;)Landroid/net/Uri;");
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
				}
				private static global::MonoJavaBridge.MethodId _m3;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Thumbnails._m3.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Thumbnails._m3 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;J)V");
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				}
				private static global::MonoJavaBridge.MethodId _m4;
				public static void cancelThumbnailRequest(android.content.ContentResolver arg0, long arg1, long arg2)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Thumbnails._m4.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Thumbnails._m4 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "cancelThumbnailRequest", "(Landroid/content/ContentResolver;JJ)V");
					@__env.CallStaticVoidMethod(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				}
				private static global::MonoJavaBridge.MethodId _m5;
				public Thumbnails() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					if (global::android.provider.MediaStore.Video.Thumbnails._m5.native == global::System.IntPtr.Zero)
						global::android.provider.MediaStore.Video.Thumbnails._m5 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "<init>", "()V");
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Video.Thumbnails.staticClass, global::android.provider.MediaStore.Video.Thumbnails._m5);
					Init(@__env, handle);
				}
				internal static global::MonoJavaBridge.FieldId _INTERNAL_CONTENT_URI4736;
				public static global::android.net.Uri INTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Video.Thumbnails.staticClass, _INTERNAL_CONTENT_URI4736)) as android.net.Uri;
					}
				}
				internal static global::MonoJavaBridge.FieldId _EXTERNAL_CONTENT_URI4737;
				public static global::android.net.Uri EXTERNAL_CONTENT_URI
				{
					get
					{
						global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
						return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.provider.MediaStore.Video.Thumbnails.staticClass, _EXTERNAL_CONTENT_URI4737)) as android.net.Uri;
					}
				}
				public static global::java.lang.String DEFAULT_SORT_ORDER
				{
					get
					{
						return "video_id ASC";
					}
				}
				public static global::java.lang.String DATA
				{
					get
					{
						return "_data";
					}
				}
				public static global::java.lang.String VIDEO_ID
				{
					get
					{
						return "video_id";
					}
				}
				public static global::java.lang.String KIND
				{
					get
					{
						return "kind";
					}
				}
				public static int MINI_KIND
				{
					get
					{
						return 1;
					}
				}
				public static int FULL_SCREEN_KIND
				{
					get
					{
						return 2;
					}
				}
				public static int MICRO_KIND
				{
					get
					{
						return 3;
					}
				}
				public static global::java.lang.String WIDTH
				{
					get
					{
						return "width";
					}
				}
				public static global::java.lang.String HEIGHT
				{
					get
					{
						return "height";
					}
				}
				static Thumbnails()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Video.Thumbnails.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video$Thumbnails"));
					global::android.provider.MediaStore.Video.Thumbnails._INTERNAL_CONTENT_URI4736 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "INTERNAL_CONTENT_URI", "Landroid/net/Uri;");
					global::android.provider.MediaStore.Video.Thumbnails._EXTERNAL_CONTENT_URI4737 = @__env.GetStaticFieldIDNoThrow(global::android.provider.MediaStore.Video.Thumbnails.staticClass, "EXTERNAL_CONTENT_URI", "Landroid/net/Uri;");
				}
			}
			[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.MediaStore.Video.VideoColumns_))]
			public partial interface VideoColumns : MediaColumns
			{
			}

			[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.MediaStore.Video.VideoColumns))]
			internal sealed partial class VideoColumns_ : java.lang.Object, VideoColumns
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				internal VideoColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				static VideoColumns_()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.provider.MediaStore.Video.VideoColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video$VideoColumns"));
				}
			}
			[global::MonoJavaBridge.JavaClass()]
			public static partial class VideoColumnsConstants 
			{
				public static global::java.lang.String DURATION
				{
					get
					{
						return "duration";
					}
				}
				public static global::java.lang.String ARTIST
				{
					get
					{
						return "artist";
					}
				}
				public static global::java.lang.String ALBUM
				{
					get
					{
						return "album";
					}
				}
				public static global::java.lang.String RESOLUTION
				{
					get
					{
						return "resolution";
					}
				}
				public static global::java.lang.String DESCRIPTION
				{
					get
					{
						return "description";
					}
				}
				public static global::java.lang.String IS_PRIVATE
				{
					get
					{
						return "isprivate";
					}
				}
				public static global::java.lang.String TAGS
				{
					get
					{
						return "tags";
					}
				}
				public static global::java.lang.String CATEGORY
				{
					get
					{
						return "category";
					}
				}
				public static global::java.lang.String LANGUAGE
				{
					get
					{
						return "language";
					}
				}
				public static global::java.lang.String LATITUDE
				{
					get
					{
						return "latitude";
					}
				}
				public static global::java.lang.String LONGITUDE
				{
					get
					{
						return "longitude";
					}
				}
				public static global::java.lang.String DATE_TAKEN
				{
					get
					{
						return "datetaken";
					}
				}
				public static global::java.lang.String MINI_THUMB_MAGIC
				{
					get
					{
						return "mini_thumb_magic";
					}
				}
				public static global::java.lang.String BUCKET_ID
				{
					get
					{
						return "bucket_id";
					}
				}
				public static global::java.lang.String BUCKET_DISPLAY_NAME
				{
					get
					{
						return "bucket_display_name";
					}
				}
				public static global::java.lang.String BOOKMARK
				{
					get
					{
						return "bookmark";
					}
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.database.Cursor query(android.content.ContentResolver arg0, android.net.Uri arg1, java.lang.String[] arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.MediaStore.Video._m0.native == global::System.IntPtr.Zero)
					global::android.provider.MediaStore.Video._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.Video.staticClass, "query", "(Landroid/content/ContentResolver;Landroid/net/Uri;[Ljava/lang/String;)Landroid/database/Cursor;");
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallStaticObjectMethod(android.provider.MediaStore.Video.staticClass, global::android.provider.MediaStore.Video._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.Cursor;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public Video() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.provider.MediaStore.Video._m1.native == global::System.IntPtr.Zero)
					global::android.provider.MediaStore.Video._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.Video.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.Video.staticClass, global::android.provider.MediaStore.Video._m1);
				Init(@__env, handle);
			}
			public static global::java.lang.String DEFAULT_SORT_ORDER
			{
				get
				{
					return "_display_name";
				}
			}
			static Video()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.provider.MediaStore.Video.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore$Video"));
			}
		}
		public static global::android.net.Uri MediaScannerUri
		{
			get
			{
				return getMediaScannerUri();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.net.Uri getMediaScannerUri()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.MediaStore._m0.native == global::System.IntPtr.Zero)
				global::android.provider.MediaStore._m0 = @__env.GetStaticMethodIDNoThrow(global::android.provider.MediaStore.staticClass, "getMediaScannerUri", "()Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.provider.MediaStore.staticClass, global::android.provider.MediaStore._m0)) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MediaStore() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.provider.MediaStore._m1.native == global::System.IntPtr.Zero)
				global::android.provider.MediaStore._m1 = @__env.GetMethodIDNoThrow(global::android.provider.MediaStore.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.provider.MediaStore.staticClass, global::android.provider.MediaStore._m1);
			Init(@__env, handle);
		}
		public static global::java.lang.String AUTHORITY
		{
			get
			{
				return "media";
			}
		}
		public static global::java.lang.String INTENT_ACTION_MUSIC_PLAYER
		{
			get
			{
				return "android.intent.action.MUSIC_PLAYER";
			}
		}
		public static global::java.lang.String INTENT_ACTION_MEDIA_SEARCH
		{
			get
			{
				return "android.intent.action.MEDIA_SEARCH";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_ARTIST
		{
			get
			{
				return "android.intent.extra.artist";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_ALBUM
		{
			get
			{
				return "android.intent.extra.album";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_TITLE
		{
			get
			{
				return "android.intent.extra.title";
			}
		}
		public static global::java.lang.String EXTRA_MEDIA_FOCUS
		{
			get
			{
				return "android.intent.extra.focus";
			}
		}
		public static global::java.lang.String EXTRA_SCREEN_ORIENTATION
		{
			get
			{
				return "android.intent.extra.screenOrientation";
			}
		}
		public static global::java.lang.String EXTRA_FULL_SCREEN
		{
			get
			{
				return "android.intent.extra.fullScreen";
			}
		}
		public static global::java.lang.String EXTRA_SHOW_ACTION_ICONS
		{
			get
			{
				return "android.intent.extra.showActionIcons";
			}
		}
		public static global::java.lang.String EXTRA_FINISH_ON_COMPLETION
		{
			get
			{
				return "android.intent.extra.finishOnCompletion";
			}
		}
		public static global::java.lang.String INTENT_ACTION_STILL_IMAGE_CAMERA
		{
			get
			{
				return "android.media.action.STILL_IMAGE_CAMERA";
			}
		}
		public static global::java.lang.String INTENT_ACTION_VIDEO_CAMERA
		{
			get
			{
				return "android.media.action.VIDEO_CAMERA";
			}
		}
		public static global::java.lang.String ACTION_IMAGE_CAPTURE
		{
			get
			{
				return "android.media.action.IMAGE_CAPTURE";
			}
		}
		public static global::java.lang.String ACTION_VIDEO_CAPTURE
		{
			get
			{
				return "android.media.action.VIDEO_CAPTURE";
			}
		}
		public static global::java.lang.String EXTRA_VIDEO_QUALITY
		{
			get
			{
				return "android.intent.extra.videoQuality";
			}
		}
		public static global::java.lang.String EXTRA_SIZE_LIMIT
		{
			get
			{
				return "android.intent.extra.sizeLimit";
			}
		}
		public static global::java.lang.String EXTRA_DURATION_LIMIT
		{
			get
			{
				return "android.intent.extra.durationLimit";
			}
		}
		public static global::java.lang.String EXTRA_OUTPUT
		{
			get
			{
				return "output";
			}
		}
		public static global::java.lang.String UNKNOWN_STRING
		{
			get
			{
				return "<unknown>";
			}
		}
		public static global::java.lang.String MEDIA_SCANNER_VOLUME
		{
			get
			{
				return "volume";
			}
		}
		static MediaStore()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.MediaStore.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/MediaStore"));
		}
	}
}
